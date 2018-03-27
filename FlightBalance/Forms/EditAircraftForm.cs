using FlightBalance.Properties;
using FlightBalance.Utility;
using System.Collections.Generic;
using System.Windows.Forms;
using FlightBalance.Utility.Enums;

namespace FlightBalance.Forms
{
    public partial class EditAircraftForm : Form
    {
        #region Constants

        private const string StationNameColumnName = "StationNameColumn";
        private const string StationTypeColumnName = "StationTypeColumn";
        private const string EnvelopeNameColumnName = "EnvelopeNameColumn";
        private const string EnvelopeNumberOfPointsColumnName = "EnvelopeNumberOfPointsColumn";

        #endregion

        #region Properties

        public Aircraft ReturnedAircraft { get; private set; }

        private string SelectedLengthUnits
        {
            get
            {
                return comboBoxLengthUnits.SelectedIndex == 0 ? "in" : "cm";
            }
        }

        private string SelectedWeightUnits
        {
            get
            {
                return comboBoxWeightUnits.SelectedIndex == 0 ? "lb" : "kg";
            }
        }

        #endregion

        #region Constructors

        public EditAircraftForm(Aircraft aircraftToEdit = null, bool templateMode = false)
        {
            InitializeComponent();

            // Prepare grids for receiving data
            SetUpGridViewColumns();

            if (aircraftToEdit != null)
            {
                PopulateInterfaceWithAircraft(aircraftToEdit, templateMode);
            }
            else
            {
                comboBoxLengthUnits.SelectedIndex = 0;
                comboBoxWeightUnits.SelectedIndex = 0;
            }
        }

        #endregion

        #region Private methods

        private void SetUpGridViewColumns()
        {
            #region Stations grid

            dataGridViewStations.Columns.Add(new DataGridViewTextBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                HeaderText = Resources.Name,
                Name = StationNameColumnName
            });

            dataGridViewStations.Columns.Add(new DataGridViewTextBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                HeaderText = Resources.Type,
                Name = StationTypeColumnName
            });

            #endregion

            #region Envelopes grid

            dataGridViewEnvelopes.Columns.Add(new DataGridViewTextBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                HeaderText = Resources.Name,
                Name = EnvelopeNameColumnName
            });

            dataGridViewEnvelopes.Columns.Add(new DataGridViewTextBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                HeaderText = Resources.NumberOfPoints,
                Name = EnvelopeNumberOfPointsColumnName
            });

            #endregion
        }

        private void AddStationToGridView(Station station)
        {
            int rowId = dataGridViewStations.Rows.Add();
            DataGridViewRow row = dataGridViewStations.Rows[rowId];

            row.Cells[StationNameColumnName].Value = station.Name;
            row.Cells[StationTypeColumnName].Value = station.Type;

            row.Tag = station;
        }

        private void AddEnvelopeToGridView(Envelope envelope)
        {
            int rowId = dataGridViewEnvelopes.Rows.Add();
            DataGridViewRow row = dataGridViewEnvelopes.Rows[rowId];

            row.Cells[EnvelopeNameColumnName].Value = envelope.Name;
            row.Cells[EnvelopeNumberOfPointsColumnName].Value = envelope.ChartPoints.Count;

            row.Tag = envelope;
        }

        private void PopulateInterfaceWithAircraft(Aircraft aircraft, bool templateMode)
        {
            if (!templateMode)
            {
                textBoxCallsign.Text = aircraft.Callsign;
            }
            textBoxType.Text = aircraft.Type;
            comboBoxLengthUnits.SelectedIndex = aircraft.LengthUnitType == UnitType.Imperial ? 0 : 1;
            comboBoxWeightUnits.SelectedIndex = aircraft.WeightUnitType == UnitType.Imperial ? 0 : 1;

            dataGridViewStations.Rows.Clear();
            aircraft.Stations.ForEach(AddStationToGridView);

            dataGridViewEnvelopes.Rows.Clear();
            aircraft.Envelopes.ForEach(AddEnvelopeToGridView);
        }

        private Aircraft ExtractAircraftFromInterface()
        {
            Aircraft result = null;

            UnitType lengthUnitType = comboBoxLengthUnits.SelectedIndex == 0 ? UnitType.Imperial : UnitType.Metric;
            UnitType weightUnitType = comboBoxWeightUnits.SelectedIndex == 0 ? UnitType.Imperial : UnitType.Metric;

            List<Station> resultStations = new List<Station>();
            foreach (DataGridViewRow row in dataGridViewStations.Rows)
            {
                resultStations.Add(row.Tag as Station);
            }

            List<Envelope> resultEnvelopes = new List<Envelope>();
            foreach (DataGridViewRow row in dataGridViewEnvelopes.Rows)
            {
                resultEnvelopes.Add(row.Tag as Envelope);
            }

            if (textBoxCallsign.Text.Length > 0 && textBoxType.Text.Length > 0 && resultStations.Count > 0 && resultEnvelopes.Count > 0)
            {
                result = new Aircraft(textBoxCallsign.Text, textBoxType.Text, lengthUnitType, weightUnitType, resultStations, resultEnvelopes);
            }

            return result;
        }

        #endregion

        #region Event handlers

        private void buttonNewStation_Click(object sender, System.EventArgs e)
        {
            using (EditStationForm editStationForm = new EditStationForm(SelectedLengthUnits, SelectedWeightUnits))
            {
                if (editStationForm.ShowDialog() == DialogResult.OK)
                {
                    AddStationToGridView(editStationForm.ReturnedStation);
                }
            }
        }

        private void toolStripMenuItemEditStation_Click(object sender, System.EventArgs e)
        {
            if (dataGridViewStations.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridViewStations.SelectedRows[0];

                Station selectedStation = selectedRow.Tag as Station;
                if (selectedStation != null)
                {
                    using (EditStationForm editStationForm = new EditStationForm(SelectedLengthUnits, SelectedWeightUnits, selectedStation))
                    {
                        if (editStationForm.ShowDialog() == DialogResult.OK)
                        {
                            selectedRow.Cells[StationNameColumnName].Value = editStationForm.ReturnedStation.Name;
                            selectedRow.Cells[StationTypeColumnName].Value = editStationForm.ReturnedStation.Type;

                            selectedRow.Tag = editStationForm.ReturnedStation;
                        }
                    }
                }
            }
        }

        private void toolStripMenuItemDeleteStation_Click(object sender, System.EventArgs e)
        {
            if (dataGridViewStations.SelectedRows.Count == 1)
            {
                if (MessageBox.Show(Resources.DeleteWarningMessage, Resources.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dataGridViewStations.Rows.Remove(dataGridViewStations.SelectedRows[0]);
                }
            }
        }
        
        private void buttonNewEnvelope_Click(object sender, System.EventArgs e)
        {
            using (EditEnvelopeForm editEnvelopeForm = new EditEnvelopeForm(SelectedLengthUnits, SelectedWeightUnits))
            {
                if (editEnvelopeForm.ShowDialog() == DialogResult.OK)
                {
                    AddEnvelopeToGridView(editEnvelopeForm.ReturnedEnvelope);
                }
            }
        }

        private void toolStripMenuItemEditEnvelope_Click(object sender, System.EventArgs e)
        {
            if (dataGridViewEnvelopes.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridViewEnvelopes.SelectedRows[0];

                Envelope selectedEnvelope = selectedRow.Tag as Envelope;
                if (selectedEnvelope != null)
                {
                    using (EditEnvelopeForm editEnvelopeForm = new EditEnvelopeForm(SelectedLengthUnits, SelectedWeightUnits, selectedEnvelope))
                    {
                        if (editEnvelopeForm.ShowDialog() == DialogResult.OK)
                        {
                            selectedRow.Cells[EnvelopeNameColumnName].Value = editEnvelopeForm.ReturnedEnvelope.Name;
                            selectedRow.Cells[EnvelopeNumberOfPointsColumnName].Value = editEnvelopeForm.ReturnedEnvelope.ChartPoints.Count;

                            selectedRow.Tag = editEnvelopeForm.ReturnedEnvelope;
                        }
                    }
                }
            }
        }

        private void toolStripMenuItemDeleteEnvelope_Click(object sender, System.EventArgs e)
        {
            if (dataGridViewEnvelopes.SelectedRows.Count == 1)
            {
                if (MessageBox.Show(Resources.DeleteWarningMessage, Resources.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dataGridViewEnvelopes.Rows.Remove(dataGridViewEnvelopes.SelectedRows[0]);
                }
            }
        }

        private void buttonSaveAircraft_Click(object sender, System.EventArgs e)
        {
            Aircraft extractedAircraft = ExtractAircraftFromInterface();
            if (extractedAircraft != null)
            {
                ReturnedAircraft = extractedAircraft;

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(Resources.InvalidAircraftEntryError, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void dataGridViewStations_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                dataGridViewStations.Rows[e.RowIndex].Selected = true;
                contextMenuStripDataGridViewStations.Show(MousePosition);
            }
        }

        private void dataGridViewEnvelopes_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                dataGridViewEnvelopes.Rows[e.RowIndex].Selected = true;
                contextMenuStripDataGridViewEnvelopes.Show(MousePosition);
            }
        }

        #endregion
    }
}
