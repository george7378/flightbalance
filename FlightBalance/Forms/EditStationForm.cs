using System;
using FlightBalance.Properties;
using FlightBalance.Utility;
using FlightBalance.Utility.Enums;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FlightBalance.Forms
{
    public partial class EditStationForm : Form
    {
        #region Constants

        private const string NameColumnName = "NameColumn";
        private const string ValueColumnName = "ValueColumn";

        private const string NameFieldTag = "NameField";
        private const string ArmFieldTag = "ArmField";
        private const string WeightFieldTag = "WeightField";
        private const string MinWeightFieldTag = "MinWeightField";
        private const string MaxWeightFieldTag = "MaxWeightField";
        private const string IsFuelFieldTag = "IsFuelField";

        #endregion

        #region Fields

        private int? _lastSetWeight;
        private readonly string _lengthUnits, _weightUnits;

        #endregion

        #region Properties

        public Station ReturnedStation { get; private set; }

        #endregion

        #region Constructors

        public EditStationForm(string lengthUnits, string weightUnits, Station stationToEdit = null)
        {
            _lengthUnits = lengthUnits;
            _weightUnits = weightUnits;

            InitializeComponent();

            // Prepare grids for receiving data
            SetUpGridViewColumns();

            if (stationToEdit != null)
            {
                PopulateInterfaceWithStation(stationToEdit);
            }
            else
            {
                comboBoxType.SelectedIndex = 0;
            }
        }

        #endregion

        #region Private methods

        private void SetUpGridViewColumns()
        {
            #region Fields grid

            dataGridViewFields.Columns.Add(new DataGridViewTextBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.LightGray },
                Name = NameColumnName,
                ReadOnly = true
            });

            dataGridViewFields.Columns.Add(new DataGridViewTextBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Name = ValueColumnName
            });

            #endregion
        }

        private void AddFieldToGridView(string name, string fieldTag, bool isCheckBoxValue = false)
        {
            int rowId = dataGridViewFields.Rows.Add();
            DataGridViewRow row = dataGridViewFields.Rows[rowId];

            row.Cells[NameColumnName].Value = name;

            if (isCheckBoxValue)
            {
                DataGridViewCheckBoxCell checkboxCell = new DataGridViewCheckBoxCell
                {
                    FalseValue = false,
                    Style = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter },
                    TrueValue = true,
                    Value = false,
                    ValueType = typeof(bool)
                };

                row.Cells[ValueColumnName] = checkboxCell;
            }
            else
            {
                row.Cells[ValueColumnName].Value = string.Empty;
            }

            row.Tag = fieldTag;
        }

        private object GetFieldValue(string fieldTag)
        {
            object result = null;

            DataGridViewRow row = dataGridViewFields.Rows.Cast<DataGridViewRow>().FirstOrDefault(fieldRow => fieldRow.Tag as string == fieldTag);
            if (row != null)
            {
                result = row.Cells[ValueColumnName].Value;
            }

            return result;
        }

        private void SetFieldValue(string fieldTag, object value)
        {
            DataGridViewRow row = dataGridViewFields.Rows.Cast<DataGridViewRow>().FirstOrDefault(fieldRow => fieldRow.Tag as string == fieldTag);
            if (row != null)
            {
                row.Cells[ValueColumnName].Value = value;
            }
        }

        private void PopulateInterfaceWithStation(Station station)
        {
            switch (station.Type)
            {
                case StationType.Fixed:
                    comboBoxType.SelectedIndex = 0;
                    break;

                case StationType.Variable:
                    comboBoxType.SelectedIndex = 1;
                    break;
            }

            SetFieldValue(NameFieldTag, station.Name);
            SetFieldValue(ArmFieldTag, station.Arm);

            switch (station.Type)
            {
                case StationType.Fixed:
                    FixedStation fixedStation = station as FixedStation;
                    if (fixedStation != null)
                    {
                        SetFieldValue(WeightFieldTag, fixedStation.Weight);
                    }
                    break;

                case StationType.Variable:
                    VariableStation variableStation = station as VariableStation;
                    if (variableStation != null)
                    {
                        _lastSetWeight = variableStation.LastSetWeight;

                        SetFieldValue(MinWeightFieldTag, variableStation.MinWeight);
                        SetFieldValue(MaxWeightFieldTag, variableStation.MaxWeight);
                        SetFieldValue(IsFuelFieldTag, variableStation.IsFuel);
                    }
                    break;
            }
        }

        private Station ExtractStationFromInterface()
        {
            Station result = null;
            bool fieldParsingSuccessful = true;

            string nameFieldValue = GetFieldValue(NameFieldTag).ToString();

            float armFieldValue;
            fieldParsingSuccessful &= float.TryParse(GetFieldValue(ArmFieldTag).ToString(), out armFieldValue);

            switch (comboBoxType.SelectedIndex)
            {
                // Fixed station
                case 0:
                    float weightFieldValue;
                    fieldParsingSuccessful &= float.TryParse(GetFieldValue(WeightFieldTag).ToString(), out weightFieldValue);

                    if (fieldParsingSuccessful && nameFieldValue.Length > 0 && weightFieldValue > 0)
                    {
                        result = new FixedStation(nameFieldValue, armFieldValue, weightFieldValue);
                    }
                    break;

                // Variable station
                case 1:
                    int minWeightFieldValue;
                    fieldParsingSuccessful &= int.TryParse(GetFieldValue(MinWeightFieldTag).ToString(), out minWeightFieldValue);

                    int maxWeightFieldValue;
                    fieldParsingSuccessful &= int.TryParse(GetFieldValue(MaxWeightFieldTag).ToString(), out maxWeightFieldValue);

                    bool isFuelFieldValue;
                    fieldParsingSuccessful &= bool.TryParse(GetFieldValue(IsFuelFieldTag).ToString(), out isFuelFieldValue);

                    if (fieldParsingSuccessful && nameFieldValue.Length > 0 && minWeightFieldValue >= 0 && maxWeightFieldValue > minWeightFieldValue)
                    {
                        int lastSetWeightValue = _lastSetWeight.HasValue ? Math.Min(Math.Max(_lastSetWeight.Value, minWeightFieldValue), maxWeightFieldValue) : minWeightFieldValue;

                        result = new VariableStation(nameFieldValue, armFieldValue, minWeightFieldValue, maxWeightFieldValue, lastSetWeightValue, isFuelFieldValue);
                    }
                    break;
            }

            return result;
        }

        #endregion

        #region Event handlers
        
        private void buttonSaveStation_Click(object sender, EventArgs e)
        {
            Station extractedStation = ExtractStationFromInterface();
            if (extractedStation != null)
            {
                ReturnedStation = extractedStation;

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                switch (comboBoxType.SelectedIndex)
                {
                    // Fixed station
                    case 0:
                        MessageBox.Show(Resources.InvalidFixedStationEntryError, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    // Variable station
                    case 1:
                        MessageBox.Show(Resources.InvalidVariableStationEntryError, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewFields.Rows.Clear();

            AddFieldToGridView(Resources.Name, NameFieldTag);
            AddFieldToGridView(string.Format("{0} ({1})", Resources.Arm, _lengthUnits), ArmFieldTag);

            switch (comboBoxType.SelectedIndex)
            {
                // Fixed station
                case 0:
                    AddFieldToGridView(string.Format("{0} ({1})", Resources.Weight, _weightUnits), WeightFieldTag);
                    break;

                // Variable station
                case 1:
                    AddFieldToGridView(string.Format("{0} ({1})", Resources.MinWeight, _weightUnits), MinWeightFieldTag);
                    AddFieldToGridView(string.Format("{0} ({1})", Resources.MaxWeight, _weightUnits), MaxWeightFieldTag);
                    AddFieldToGridView(Resources.IsFuel, IsFuelFieldTag, true);
                    break;
            }
        }

        #endregion
    }
}
