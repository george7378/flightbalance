using FlightBalance.Properties;
using FlightBalance.Utility;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FlightBalance.Forms
{
    public partial class EditEnvelopeForm : Form
    {
        #region Constants

        private const string ArmColumnName = "ArmColumn";
        private const string WeightColumnName = "WeightColumn";

        #endregion

        #region Fields

        private readonly string _lengthUnits, _weightUnits;

        #endregion

        #region Properties

        public Envelope ReturnedEnvelope { get; private set; }

        #endregion

        #region Constructors

        public EditEnvelopeForm(string lengthUnits, string weightUnits, Envelope envelopeToEdit = null)
        {
            _lengthUnits = lengthUnits;
            _weightUnits = weightUnits;

            InitializeComponent();

            // Prepare grids for receiving data
            SetUpGridViewColumns();

            if (envelopeToEdit != null)
            {
                PopulateInterfaceWithEnvelope(envelopeToEdit);
            }
        }

        #endregion

        #region Private methods

        private void SetUpGridViewColumns()
        {
            #region Points grid

            dataGridViewChartPoints.Columns.Add(new DataGridViewTextBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                HeaderText = string.Format("{0} ({1})", Resources.Arm, _lengthUnits),
                Name = ArmColumnName
            });

            dataGridViewChartPoints.Columns.Add(new DataGridViewTextBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                HeaderText = string.Format("{0} ({1})", Resources.Weight, _weightUnits),
                Name = WeightColumnName
            });

            #endregion
        }

        private void AddChartPointToGridView(ChartPoint chartPoint)
        {
            int rowId = dataGridViewChartPoints.Rows.Add();
            DataGridViewRow row = dataGridViewChartPoints.Rows[rowId];

            row.Cells[ArmColumnName].Value = chartPoint.Arm;
            row.Cells[WeightColumnName].Value = chartPoint.Weight;
        }

        private void PopulateInterfaceWithEnvelope(Envelope envelope)
        {
            textBoxName.Text = envelope.Name;

            dataGridViewChartPoints.Rows.Clear();
            envelope.ChartPoints.ForEach(AddChartPointToGridView);

            panelSelectedColour.BackColor = envelope.ChartColour.Colour;
        }

        private Envelope ExtractEnvelopeFromInterface()
        {
            Envelope result = null;
            bool fieldParsingSuccessful = true;

            List<ChartPoint> resultChartPoints = new List<ChartPoint>();
            foreach (DataGridViewRow row in dataGridViewChartPoints.Rows)
            {
                if (!row.IsNewRow)
                {
                    float chartPointArm;
                    fieldParsingSuccessful &= float.TryParse(row.Cells[ArmColumnName].Value.ToString(), out chartPointArm);

                    float chartPointWeight;
                    fieldParsingSuccessful &= float.TryParse(row.Cells[WeightColumnName].Value.ToString(), out chartPointWeight);
                    
                    resultChartPoints.Add(new ChartPoint(chartPointArm, chartPointWeight));
                }
            }
            
            if (fieldParsingSuccessful && textBoxName.Text.Length > 0 && resultChartPoints.Count >= 2)
            {
                result = new Envelope(textBoxName.Text, resultChartPoints, new SerializableColour(panelSelectedColour.BackColor));
            }

            return result;
        }

        #endregion

        #region Event handlers

        private void toolStripMenuItemDeleteChartPoint_Click(object sender, System.EventArgs e)
        {
            if (dataGridViewChartPoints.SelectedCells.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridViewChartPoints.SelectedCells[0].OwningRow;
                if (!selectedRow.IsNewRow)
                {
                    dataGridViewChartPoints.Rows.Remove(selectedRow);
                }
            }
        }

        private void buttonSetColour_Click(object sender, System.EventArgs e)
        {
            colorDialogEnvelopeChart.Color = panelSelectedColour.BackColor;

            if (colorDialogEnvelopeChart.ShowDialog() == DialogResult.OK)
            {
                panelSelectedColour.BackColor = colorDialogEnvelopeChart.Color;
            }
        }

        private void buttonSaveEnvelope_Click(object sender, System.EventArgs e)
        {
            Envelope extractedEnvelope = ExtractEnvelopeFromInterface();
            if (extractedEnvelope != null)
            {
                ReturnedEnvelope = extractedEnvelope;

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(Resources.InvalidEnvelopeEntryError, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewChartPoints_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                DataGridViewCell clickedCell = dataGridViewChartPoints.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (!clickedCell.OwningRow.IsNewRow)
                {
                    clickedCell.Selected = true;
                    contextMenuStripDataGridViewChartPoints.Show(MousePosition);
                }
            }
        }

        private void dataGridViewChartPoints_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[ArmColumnName].Value = string.Empty;
            e.Row.Cells[WeightColumnName].Value = string.Empty;
        }

        #endregion
    }
}
