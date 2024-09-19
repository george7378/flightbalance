using FlightBalance.Utility;
using System;
using System.Windows.Forms;

namespace FlightBalance.Controls
{
    public partial class VariableStationControl : UserControl
    {
        #region Properties

        public VariableStation AssociatedStation { get; private set; }

        public int Weight
        {
            get
            {
                return trackBarVariableStationWeight.Value;
            }
            set
            {
                trackBarVariableStationWeight.Value = value;
            }
        }

        #endregion

        #region Events

        public event EventHandler SelectedWeightChanged;

        #endregion

        #region Constructors

        public VariableStationControl(VariableStation variableStation)
        {
            AssociatedStation = variableStation;

            InitializeComponent();
            
            labelVariableStationName.Text = AssociatedStation.Name;

            trackBarVariableStationWeight.Minimum = AssociatedStation.MinWeight;
            trackBarVariableStationWeight.Maximum = AssociatedStation.MaxWeight;

            numericUpDownVariableStationWeight.Minimum = AssociatedStation.MinWeight;
            numericUpDownVariableStationWeight.Maximum = AssociatedStation.MaxWeight;
        }

        #endregion

        #region Event handlers

        private void trackBarVariableStationWeight_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownVariableStationWeight.Value = trackBarVariableStationWeight.Value;

            if (SelectedWeightChanged != null)
            {
                SelectedWeightChanged(this, new EventArgs());
            }
        }

        private void numericUpDownVariableStationWeight_ValueChanged(object sender, EventArgs e)
        {
            trackBarVariableStationWeight.Value = Convert.ToInt32(numericUpDownVariableStationWeight.Value);
        }

        #endregion
    }
}
