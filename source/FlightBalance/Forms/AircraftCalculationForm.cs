using FlightBalance.Controls;
using FlightBalance.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FlightBalance.Properties;

namespace FlightBalance.Forms
{
    public partial class AircraftCalculationForm : Form
    {
        #region Fields

        private readonly List<FixedStation> _fixedStations;
        private readonly Series _calculationSeries;

        #endregion

        #region Constructors

        public AircraftCalculationForm(Aircraft aircraft)
        {
            _fixedStations = aircraft.Stations.Where(station => station.GetType() == typeof(FixedStation)).Cast<FixedStation>().ToList();

            InitializeComponent();

            #region Populate variable stations

            List<VariableStation> variableStations = aircraft.Stations.Where(station => station.GetType() == typeof(VariableStation)).Cast<VariableStation>().Reverse().ToList();
            foreach (VariableStation variableStation in variableStations)
            {
                VariableStationControl variableStationControl = new VariableStationControl(variableStation) { Dock = DockStyle.Top };
                panelVariableStations.Controls.Add(variableStationControl);

                variableStationControl.SelectedWeightChanged += VariableStationControl_SelectedWeightChanged;

                variableStationControl.Weight = Math.Min(Math.Max(variableStation.LastSetWeight, variableStation.MinWeight), variableStation.MaxWeight);
            }
            panelVariableStations.Controls.Cast<Control>().Last().Select();

            #endregion

            #region Set up chart

            if (chartCalculation.ChartAreas.Any())
            {
                chartCalculation.ChartAreas[0].AxisX.Title = string.Format("{0} / {1}", Resources.CgPosition, aircraft.LengthUnits);
                chartCalculation.ChartAreas[0].AxisY.Title = string.Format("{0} / {1}", Resources.TotalWeight, aircraft.WeightUnits);
            }

            chartCalculation.Series.Clear();

            foreach (Envelope envelope in aircraft.Envelopes)
            {
                Series envelopeSeries = new Series
                {
                    BorderWidth = 3,
                    ChartType = SeriesChartType.Line,
                    Color = envelope.ChartColour.Colour,
                    Name = envelope.Name,
                    Tag = true  // Signifies that this series is an envelope
                };

                foreach (ChartPoint chartPoint in envelope.ChartPoints)
                {
                    envelopeSeries.Points.AddXY(chartPoint.Arm, chartPoint.Weight);
                }

                chartCalculation.Series.Add(envelopeSeries);
            }

            FitChartAxesToEnvelopes();

            _calculationSeries = new Series
            {
                ChartType = SeriesChartType.Point,
                Color = Color.Red,
                IsVisibleInLegend = false,
                MarkerSize = 10,
                MarkerStyle = MarkerStyle.Circle,
                Name = "Calculation"
            };

            UpdateCalculation();

            chartCalculation.Series.Add(_calculationSeries);

            #endregion
        }

        #endregion

        #region Private methods

        private void FitChartAxesToEnvelopes()
        {
            double smallestXValue = double.MaxValue;
            double largestXValue = double.MinValue;
            double smallestYValue = double.MaxValue;
            double largestYValue = double.MinValue;

            bool atLeastOneEnvelopeExists = false;

            foreach (Series series in chartCalculation.Series)
            {
                // Does tag signify that this series is an envelope?
                bool? tagBoolValue = series.Tag as bool?;
                if (tagBoolValue.HasValue && tagBoolValue.Value)
                {
                    atLeastOneEnvelopeExists = true;

                    foreach (DataPoint dataPoint in series.Points)
                    {
                        if (dataPoint.XValue < smallestXValue)
                        {
                            smallestXValue = dataPoint.XValue;
                        }
                        if (dataPoint.XValue > largestXValue)
                        {
                            largestXValue = dataPoint.XValue;
                        }

                        if (dataPoint.YValues.Any())
                        {
                            if (dataPoint.YValues[0] < smallestYValue)
                            {
                                smallestYValue = dataPoint.YValues[0];
                            }
                            if (dataPoint.YValues[0] > largestYValue)
                            {
                                largestYValue = dataPoint.YValues[0];
                            }
                        }
                    }
                }
            }

            if (atLeastOneEnvelopeExists && chartCalculation.ChartAreas.Any())
            {
                chartCalculation.ChartAreas[0].AxisX.Minimum = Convert.ToInt32(Math.Floor(smallestXValue - 1));
                chartCalculation.ChartAreas[0].AxisX.Maximum = Convert.ToInt32(Math.Ceiling(largestXValue + 1));
                chartCalculation.ChartAreas[0].AxisY.Minimum = Convert.ToInt32(smallestYValue);
                chartCalculation.ChartAreas[0].AxisY.Maximum = Convert.ToInt32(Math.Ceiling((largestYValue + 100)/100)*100);

                chartCalculation.ChartAreas[0].AxisX.Interval = Convert.ToInt32(Math.Max(Math.Floor((chartCalculation.ChartAreas[0].AxisX.Maximum - chartCalculation.ChartAreas[0].AxisX.Minimum)/5), 1));
                chartCalculation.ChartAreas[0].AxisY.Interval = Convert.ToInt32(Math.Max(Math.Floor((chartCalculation.ChartAreas[0].AxisY.Maximum - chartCalculation.ChartAreas[0].AxisY.Minimum)/500)*100, 100));

                chartCalculation.ChartAreas[0].AxisX.RoundAxisValues();
            }
        }

        private void UpdateCalculation()
        {
            float totalWeight = 0;
            float totalMoment = 0;
            float totalWeightNoFuel = 0;
            float totalMomentNoFuel = 0;

            foreach (Control control in panelVariableStations.Controls)
            {
                VariableStationControl variableStationControl = control as VariableStationControl;
                if (variableStationControl != null)
                {
                    totalWeight += variableStationControl.Weight;
                    totalMoment += variableStationControl.Weight*variableStationControl.AssociatedStation.Arm;

                    if (!variableStationControl.AssociatedStation.IsFuel)
                    {
                        totalWeightNoFuel += variableStationControl.Weight;
                        totalMomentNoFuel += variableStationControl.Weight*variableStationControl.AssociatedStation.Arm;
                    }
                }
            }

            foreach (FixedStation fixedStation in _fixedStations)
            {
                totalWeight += fixedStation.Weight;
                totalMoment += fixedStation.Weight*fixedStation.Arm;
                totalWeightNoFuel += fixedStation.Weight;
                totalMomentNoFuel += fixedStation.Weight*fixedStation.Arm;
            }
            
            double calculationPointXValue = totalMoment/totalWeight;
            double calculationPointYValue = totalWeight;
            double calculationPointXValueNoFuel = totalMomentNoFuel/totalWeightNoFuel;
            double calculationPointYValueNoFuel = totalWeightNoFuel;

            if (chartCalculation.ChartAreas.Any())
            {
                calculationPointXValue = Math.Min(Math.Max(calculationPointXValue, chartCalculation.ChartAreas[0].AxisX.Minimum), chartCalculation.ChartAreas[0].AxisX.Maximum);
                calculationPointYValue = Math.Min(Math.Max(calculationPointYValue, chartCalculation.ChartAreas[0].AxisY.Minimum), chartCalculation.ChartAreas[0].AxisY.Maximum);
                calculationPointXValueNoFuel = Math.Min(Math.Max(calculationPointXValueNoFuel, chartCalculation.ChartAreas[0].AxisX.Minimum), chartCalculation.ChartAreas[0].AxisX.Maximum);
                calculationPointYValueNoFuel = Math.Min(Math.Max(calculationPointYValueNoFuel, chartCalculation.ChartAreas[0].AxisY.Minimum), chartCalculation.ChartAreas[0].AxisY.Maximum);
            }

            _calculationSeries.Points.Clear();
            _calculationSeries.Points.AddXY(calculationPointXValue, calculationPointYValue);
            _calculationSeries.Points.Add(new DataPoint
            {
                BorderWidth = 2,
                MarkerBorderColor = Color.Red,
                MarkerColor = Color.Transparent,
                XValue = calculationPointXValueNoFuel,
                YValues = new [] { calculationPointYValueNoFuel }
            });
        }

        #endregion

        #region Event handlers

        private void VariableStationControl_SelectedWeightChanged(object sender, EventArgs e)
        {
            if (_calculationSeries != null)
            {
                UpdateCalculation();
            }
        }

        private void AircraftCalculationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Control control in panelVariableStations.Controls)
            {
                VariableStationControl variableStationControl = control as VariableStationControl;
                if (variableStationControl != null)
                {
                    variableStationControl.AssociatedStation.LastSetWeight = variableStationControl.Weight;
                }
            }
        }

        #endregion
    }
}
