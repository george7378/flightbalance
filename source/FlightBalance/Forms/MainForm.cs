using FlightBalance.Properties;
using FlightBalance.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FlightBalance.Forms
{
    public partial class MainForm : Form
    {
        #region Constants

        private const string CallsignColumnName = "CallsignColumn";
        private const string TypeColumnName = "TypeColumn";

        #endregion

        #region Constructors

        public MainForm()
        {
            InitializeComponent();

            // Prepare grids for receiving data
            SetUpGridViewColumns();

            if (!LoadAircraft())
            {
                MessageBox.Show(Resources.AircraftLoadError, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Private methods

        private void SetUpGridViewColumns()
        {
            #region Aircraft grid

            dataGridViewAircraft.Columns.Add(new DataGridViewTextBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                HeaderText = Resources.Callsign,
                Name = CallsignColumnName
            });

            dataGridViewAircraft.Columns.Add(new DataGridViewTextBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                HeaderText = Resources.Type,
                Name = TypeColumnName
            });

            #endregion
        }

        private void AddAircraftToGridView(Aircraft aircraft)
        {
            int rowId = dataGridViewAircraft.Rows.Add();
            DataGridViewRow row = dataGridViewAircraft.Rows[rowId];

            row.Cells[CallsignColumnName].Value = aircraft.Callsign;
            row.Cells[TypeColumnName].Value = aircraft.Type;

            row.Tag = aircraft;
        }

        private bool SaveAircraft()
        {
            List<Aircraft> allAircraft = new List<Aircraft>();
            foreach (DataGridViewRow row in dataGridViewAircraft.Rows)
            {
                Aircraft rowAircraft = row.Tag as Aircraft;
                if (rowAircraft != null)
                {
                    allAircraft.Add(rowAircraft);
                }
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Aircraft>));

            try
            {
                using (StreamWriter streamWriter = new StreamWriter(Path.Combine(Environment.CurrentDirectory, "Aircraft.xml")))
                {
                    xmlSerializer.Serialize(streamWriter, allAircraft);
                }
            }
            catch
            {
                return false; 
            }

            return true;
        }

        private bool LoadAircraft()
        {
            string aircraftFileLocation = Path.Combine(Environment.CurrentDirectory, "Aircraft.xml");

            if (File.Exists(aircraftFileLocation))
            {
                List<Aircraft> allAircraft;

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Aircraft>));

                try
                {
                    using (StreamReader streamReader = new StreamReader(aircraftFileLocation))
                    {
                        allAircraft = (List<Aircraft>)xmlSerializer.Deserialize(streamReader);
                    }
                }
                catch
                {
                    return false;
                }

                dataGridViewAircraft.Rows.Clear();
                allAircraft.ForEach(AddAircraftToGridView);
            }

            return true;
        }

        #endregion

        #region Event handlers

        private void buttonNewAircraft_Click(object sender, EventArgs e)
        {
            using (EditAircraftForm editAircraftForm = new EditAircraftForm())
            {
                if (editAircraftForm.ShowDialog() == DialogResult.OK)
                {
                    AddAircraftToGridView(editAircraftForm.ReturnedAircraft);
                }
            }
        }

        private void toolStripMenuItemNewFromThis_Click(object sender, EventArgs e)
        {
            if (dataGridViewAircraft.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridViewAircraft.SelectedRows[0];

                Aircraft selectedAircraft = selectedRow.Tag as Aircraft;
                if (selectedAircraft != null)
                {
                    using (EditAircraftForm editAircraftForm = new EditAircraftForm(selectedAircraft.Clone(), true))
                    {
                        if (editAircraftForm.ShowDialog() == DialogResult.OK)
                        {
                            AddAircraftToGridView(editAircraftForm.ReturnedAircraft);
                        }
                    }
                }
            }
        }

        private void toolStripMenuItemEditAircraft_Click(object sender, EventArgs e)
        {
            if (dataGridViewAircraft.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridViewAircraft.SelectedRows[0];

                Aircraft selectedAircraft = selectedRow.Tag as Aircraft;
                if (selectedAircraft != null)
                {
                    using (EditAircraftForm editAircraftForm = new EditAircraftForm(selectedAircraft.Clone()))
                    {
                        if (editAircraftForm.ShowDialog() == DialogResult.OK)
                        {
                            selectedRow.Cells[CallsignColumnName].Value = editAircraftForm.ReturnedAircraft.Callsign;
                            selectedRow.Cells[TypeColumnName].Value = editAircraftForm.ReturnedAircraft.Type;

                            selectedRow.Tag = editAircraftForm.ReturnedAircraft;
                        }
                    }
                }
            }
        }

        private void toolStripMenuItemDeleteAircraft_Click(object sender, EventArgs e)
        {
            if (dataGridViewAircraft.SelectedRows.Count == 1)
            {
                if (MessageBox.Show(Resources.DeleteWarningMessage, Resources.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dataGridViewAircraft.Rows.Remove(dataGridViewAircraft.SelectedRows[0]);
                }
            }
        }

        private void dataGridViewAircraft_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                dataGridViewAircraft.Rows[e.RowIndex].Selected = true;
                contextMenuStripDataGridViewAircraft.Show(MousePosition);
            }
        }

        private void dataGridViewAircraft_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Aircraft selectedAircraft = dataGridViewAircraft.Rows[e.RowIndex].Tag as Aircraft;
                if (selectedAircraft != null)
                {
                    using (AircraftCalculationForm aircraftCalculationForm = new AircraftCalculationForm(selectedAircraft))
                    {
                        aircraftCalculationForm.Text = string.Format("{0} - {1}", aircraftCalculationForm.Text, selectedAircraft.Callsign);
                        aircraftCalculationForm.ShowDialog();
                    }
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!SaveAircraft())
            {
                MessageBox.Show(Resources.AircraftSaveError, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
