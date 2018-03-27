namespace FlightBalance.Forms
{
    partial class AircraftCalculationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tableLayoutPanelAircraftCalculation = new System.Windows.Forms.TableLayoutPanel();
            this.chartCalculation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxVariableStations = new System.Windows.Forms.GroupBox();
            this.panelVariableStations = new System.Windows.Forms.Panel();
            this.tableLayoutPanelAircraftCalculation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCalculation)).BeginInit();
            this.groupBoxVariableStations.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelAircraftCalculation
            // 
            this.tableLayoutPanelAircraftCalculation.AutoScroll = true;
            this.tableLayoutPanelAircraftCalculation.ColumnCount = 2;
            this.tableLayoutPanelAircraftCalculation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAircraftCalculation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAircraftCalculation.Controls.Add(this.chartCalculation, 1, 0);
            this.tableLayoutPanelAircraftCalculation.Controls.Add(this.groupBoxVariableStations, 0, 0);
            this.tableLayoutPanelAircraftCalculation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAircraftCalculation.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAircraftCalculation.Name = "tableLayoutPanelAircraftCalculation";
            this.tableLayoutPanelAircraftCalculation.RowCount = 1;
            this.tableLayoutPanelAircraftCalculation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAircraftCalculation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAircraftCalculation.Size = new System.Drawing.Size(684, 412);
            this.tableLayoutPanelAircraftCalculation.TabIndex = 0;
            // 
            // chartCalculation
            // 
            this.chartCalculation.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartAreaCalculation";
            this.chartCalculation.ChartAreas.Add(chartArea1);
            this.chartCalculation.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "LegendEnvelopes";
            this.chartCalculation.Legends.Add(legend1);
            this.chartCalculation.Location = new System.Drawing.Point(354, 12);
            this.chartCalculation.Margin = new System.Windows.Forms.Padding(12);
            this.chartCalculation.Name = "chartCalculation";
            this.chartCalculation.Size = new System.Drawing.Size(318, 388);
            this.chartCalculation.TabIndex = 0;
            // 
            // groupBoxVariableStations
            // 
            this.groupBoxVariableStations.Controls.Add(this.panelVariableStations);
            this.groupBoxVariableStations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxVariableStations.Location = new System.Drawing.Point(12, 12);
            this.groupBoxVariableStations.Margin = new System.Windows.Forms.Padding(12);
            this.groupBoxVariableStations.Name = "groupBoxVariableStations";
            this.groupBoxVariableStations.Size = new System.Drawing.Size(318, 388);
            this.groupBoxVariableStations.TabIndex = 0;
            this.groupBoxVariableStations.TabStop = false;
            this.groupBoxVariableStations.Text = "Variable stations";
            // 
            // panelVariableStations
            // 
            this.panelVariableStations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVariableStations.AutoScroll = true;
            this.panelVariableStations.Location = new System.Drawing.Point(9, 19);
            this.panelVariableStations.Name = "panelVariableStations";
            this.panelVariableStations.Size = new System.Drawing.Size(303, 360);
            this.panelVariableStations.TabIndex = 1;
            // 
            // AircraftCalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.tableLayoutPanelAircraftCalculation);
            this.Name = "AircraftCalculationForm";
            this.Text = "Aircraft Calculation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AircraftCalculationForm_FormClosing);
            this.tableLayoutPanelAircraftCalculation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCalculation)).EndInit();
            this.groupBoxVariableStations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAircraftCalculation;
        private System.Windows.Forms.GroupBox groupBoxVariableStations;
        private System.Windows.Forms.Panel panelVariableStations;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCalculation;
    }
}