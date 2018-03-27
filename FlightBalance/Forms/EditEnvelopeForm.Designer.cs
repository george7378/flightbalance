namespace FlightBalance.Forms
{
    partial class EditEnvelopeForm
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
            this.components = new System.ComponentModel.Container();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxChartPoints = new System.Windows.Forms.GroupBox();
            this.panelSelectedColour = new System.Windows.Forms.Panel();
            this.buttonSetColour = new System.Windows.Forms.Button();
            this.dataGridViewChartPoints = new System.Windows.Forms.DataGridView();
            this.colorDialogEnvelopeChart = new System.Windows.Forms.ColorDialog();
            this.buttonSaveEnvelope = new System.Windows.Forms.Button();
            this.contextMenuStripDataGridViewChartPoints = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemDeleteChartPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxChartPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChartPoints)).BeginInit();
            this.contextMenuStripDataGridViewChartPoints.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(53, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(219, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // groupBoxChartPoints
            // 
            this.groupBoxChartPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxChartPoints.Controls.Add(this.panelSelectedColour);
            this.groupBoxChartPoints.Controls.Add(this.buttonSetColour);
            this.groupBoxChartPoints.Controls.Add(this.dataGridViewChartPoints);
            this.groupBoxChartPoints.Location = new System.Drawing.Point(12, 38);
            this.groupBoxChartPoints.Name = "groupBoxChartPoints";
            this.groupBoxChartPoints.Size = new System.Drawing.Size(260, 183);
            this.groupBoxChartPoints.TabIndex = 2;
            this.groupBoxChartPoints.TabStop = false;
            this.groupBoxChartPoints.Text = "Chart points";
            // 
            // panelSelectedColour
            // 
            this.panelSelectedColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSelectedColour.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelSelectedColour.Location = new System.Drawing.Point(87, 154);
            this.panelSelectedColour.Name = "panelSelectedColour";
            this.panelSelectedColour.Size = new System.Drawing.Size(23, 23);
            this.panelSelectedColour.TabIndex = 5;
            // 
            // buttonSetColour
            // 
            this.buttonSetColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSetColour.Location = new System.Drawing.Point(6, 154);
            this.buttonSetColour.Name = "buttonSetColour";
            this.buttonSetColour.Size = new System.Drawing.Size(75, 23);
            this.buttonSetColour.TabIndex = 4;
            this.buttonSetColour.Text = "Set Colour...";
            this.buttonSetColour.UseVisualStyleBackColor = true;
            this.buttonSetColour.Click += new System.EventHandler(this.buttonSetColour_Click);
            // 
            // dataGridViewChartPoints
            // 
            this.dataGridViewChartPoints.AllowUserToDeleteRows = false;
            this.dataGridViewChartPoints.AllowUserToResizeRows = false;
            this.dataGridViewChartPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewChartPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChartPoints.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridViewChartPoints.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewChartPoints.MultiSelect = false;
            this.dataGridViewChartPoints.Name = "dataGridViewChartPoints";
            this.dataGridViewChartPoints.RowHeadersVisible = false;
            this.dataGridViewChartPoints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewChartPoints.Size = new System.Drawing.Size(248, 129);
            this.dataGridViewChartPoints.TabIndex = 3;
            this.dataGridViewChartPoints.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewChartPoints_CellMouseDown);
            this.dataGridViewChartPoints.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewChartPoints_DefaultValuesNeeded);
            // 
            // colorDialogEnvelopeChart
            // 
            this.colorDialogEnvelopeChart.FullOpen = true;
            // 
            // buttonSaveEnvelope
            // 
            this.buttonSaveEnvelope.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveEnvelope.Location = new System.Drawing.Point(197, 227);
            this.buttonSaveEnvelope.Name = "buttonSaveEnvelope";
            this.buttonSaveEnvelope.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveEnvelope.TabIndex = 6;
            this.buttonSaveEnvelope.Text = "Save";
            this.buttonSaveEnvelope.UseVisualStyleBackColor = true;
            this.buttonSaveEnvelope.Click += new System.EventHandler(this.buttonSaveEnvelope_Click);
            // 
            // contextMenuStripDataGridViewChartPoints
            // 
            this.contextMenuStripDataGridViewChartPoints.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDeleteChartPoint});
            this.contextMenuStripDataGridViewChartPoints.Name = "contextMenuStripDataGridViewAircraft";
            this.contextMenuStripDataGridViewChartPoints.Size = new System.Drawing.Size(108, 26);
            // 
            // toolStripMenuItemDeleteChartPoint
            // 
            this.toolStripMenuItemDeleteChartPoint.Name = "toolStripMenuItemDeleteChartPoint";
            this.toolStripMenuItemDeleteChartPoint.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemDeleteChartPoint.Text = "Delete";
            this.toolStripMenuItemDeleteChartPoint.Click += new System.EventHandler(this.toolStripMenuItemDeleteChartPoint_Click);
            // 
            // EditEnvelopeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonSaveEnvelope);
            this.Controls.Add(this.groupBoxChartPoints);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Name = "EditEnvelopeForm";
            this.Text = "Edit Envelope";
            this.groupBoxChartPoints.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChartPoints)).EndInit();
            this.contextMenuStripDataGridViewChartPoints.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBoxChartPoints;
        private System.Windows.Forms.DataGridView dataGridViewChartPoints;
        private System.Windows.Forms.ColorDialog colorDialogEnvelopeChart;
        private System.Windows.Forms.Button buttonSetColour;
        private System.Windows.Forms.Button buttonSaveEnvelope;
        private System.Windows.Forms.Panel panelSelectedColour;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDataGridViewChartPoints;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteChartPoint;
    }
}