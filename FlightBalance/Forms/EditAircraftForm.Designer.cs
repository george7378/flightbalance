namespace FlightBalance.Forms
{
    partial class EditAircraftForm
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
            this.tabControlEditAircraft = new System.Windows.Forms.TabControl();
            this.tabPageInformation = new System.Windows.Forms.TabPage();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxCallsign = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelCallsign = new System.Windows.Forms.Label();
            this.tabPageStations = new System.Windows.Forms.TabPage();
            this.buttonNewStation = new System.Windows.Forms.Button();
            this.dataGridViewStations = new System.Windows.Forms.DataGridView();
            this.tabPageEnvelopes = new System.Windows.Forms.TabPage();
            this.buttonNewEnvelope = new System.Windows.Forms.Button();
            this.dataGridViewEnvelopes = new System.Windows.Forms.DataGridView();
            this.buttonSaveAircraft = new System.Windows.Forms.Button();
            this.contextMenuStripDataGridViewStations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEditStation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteStation = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripDataGridViewEnvelopes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEditEnvelope = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteEnvelope = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxLengthUnits = new System.Windows.Forms.ComboBox();
            this.labelLengthUnits = new System.Windows.Forms.Label();
            this.labelWeightUnits = new System.Windows.Forms.Label();
            this.comboBoxWeightUnits = new System.Windows.Forms.ComboBox();
            this.tabControlEditAircraft.SuspendLayout();
            this.tabPageInformation.SuspendLayout();
            this.tabPageStations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStations)).BeginInit();
            this.tabPageEnvelopes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnvelopes)).BeginInit();
            this.contextMenuStripDataGridViewStations.SuspendLayout();
            this.contextMenuStripDataGridViewEnvelopes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlEditAircraft
            // 
            this.tabControlEditAircraft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlEditAircraft.Controls.Add(this.tabPageInformation);
            this.tabControlEditAircraft.Controls.Add(this.tabPageStations);
            this.tabControlEditAircraft.Controls.Add(this.tabPageEnvelopes);
            this.tabControlEditAircraft.Location = new System.Drawing.Point(12, 12);
            this.tabControlEditAircraft.Name = "tabControlEditAircraft";
            this.tabControlEditAircraft.SelectedIndex = 0;
            this.tabControlEditAircraft.Size = new System.Drawing.Size(260, 209);
            this.tabControlEditAircraft.TabIndex = 0;
            // 
            // tabPageInformation
            // 
            this.tabPageInformation.Controls.Add(this.labelWeightUnits);
            this.tabPageInformation.Controls.Add(this.comboBoxWeightUnits);
            this.tabPageInformation.Controls.Add(this.labelLengthUnits);
            this.tabPageInformation.Controls.Add(this.comboBoxLengthUnits);
            this.tabPageInformation.Controls.Add(this.textBoxType);
            this.tabPageInformation.Controls.Add(this.textBoxCallsign);
            this.tabPageInformation.Controls.Add(this.labelType);
            this.tabPageInformation.Controls.Add(this.labelCallsign);
            this.tabPageInformation.Location = new System.Drawing.Point(4, 22);
            this.tabPageInformation.Name = "tabPageInformation";
            this.tabPageInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInformation.Size = new System.Drawing.Size(252, 183);
            this.tabPageInformation.TabIndex = 0;
            this.tabPageInformation.Text = "Information";
            this.tabPageInformation.UseVisualStyleBackColor = true;
            // 
            // textBoxType
            // 
            this.textBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxType.Location = new System.Drawing.Point(78, 32);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(168, 20);
            this.textBoxType.TabIndex = 3;
            // 
            // textBoxCallsign
            // 
            this.textBoxCallsign.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCallsign.Location = new System.Drawing.Point(78, 6);
            this.textBoxCallsign.Name = "textBoxCallsign";
            this.textBoxCallsign.Size = new System.Drawing.Size(168, 20);
            this.textBoxCallsign.TabIndex = 1;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(6, 35);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Type";
            // 
            // labelCallsign
            // 
            this.labelCallsign.AutoSize = true;
            this.labelCallsign.Location = new System.Drawing.Point(6, 9);
            this.labelCallsign.Name = "labelCallsign";
            this.labelCallsign.Size = new System.Drawing.Size(43, 13);
            this.labelCallsign.TabIndex = 0;
            this.labelCallsign.Text = "Callsign";
            // 
            // tabPageStations
            // 
            this.tabPageStations.Controls.Add(this.buttonNewStation);
            this.tabPageStations.Controls.Add(this.dataGridViewStations);
            this.tabPageStations.Location = new System.Drawing.Point(4, 22);
            this.tabPageStations.Name = "tabPageStations";
            this.tabPageStations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStations.Size = new System.Drawing.Size(252, 183);
            this.tabPageStations.TabIndex = 1;
            this.tabPageStations.Text = "Stations";
            this.tabPageStations.UseVisualStyleBackColor = true;
            // 
            // buttonNewStation
            // 
            this.buttonNewStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewStation.Location = new System.Drawing.Point(171, 154);
            this.buttonNewStation.Name = "buttonNewStation";
            this.buttonNewStation.Size = new System.Drawing.Size(75, 23);
            this.buttonNewStation.TabIndex = 1;
            this.buttonNewStation.Text = "New...";
            this.buttonNewStation.UseVisualStyleBackColor = true;
            this.buttonNewStation.Click += new System.EventHandler(this.buttonNewStation_Click);
            // 
            // dataGridViewStations
            // 
            this.dataGridViewStations.AllowUserToAddRows = false;
            this.dataGridViewStations.AllowUserToDeleteRows = false;
            this.dataGridViewStations.AllowUserToResizeRows = false;
            this.dataGridViewStations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStations.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewStations.MultiSelect = false;
            this.dataGridViewStations.Name = "dataGridViewStations";
            this.dataGridViewStations.ReadOnly = true;
            this.dataGridViewStations.RowHeadersVisible = false;
            this.dataGridViewStations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStations.Size = new System.Drawing.Size(240, 142);
            this.dataGridViewStations.TabIndex = 0;
            this.dataGridViewStations.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewStations_CellMouseDown);
            // 
            // tabPageEnvelopes
            // 
            this.tabPageEnvelopes.Controls.Add(this.buttonNewEnvelope);
            this.tabPageEnvelopes.Controls.Add(this.dataGridViewEnvelopes);
            this.tabPageEnvelopes.Location = new System.Drawing.Point(4, 22);
            this.tabPageEnvelopes.Name = "tabPageEnvelopes";
            this.tabPageEnvelopes.Size = new System.Drawing.Size(252, 183);
            this.tabPageEnvelopes.TabIndex = 2;
            this.tabPageEnvelopes.Text = "Envelopes";
            this.tabPageEnvelopes.UseVisualStyleBackColor = true;
            // 
            // buttonNewEnvelope
            // 
            this.buttonNewEnvelope.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewEnvelope.Location = new System.Drawing.Point(171, 154);
            this.buttonNewEnvelope.Name = "buttonNewEnvelope";
            this.buttonNewEnvelope.Size = new System.Drawing.Size(75, 23);
            this.buttonNewEnvelope.TabIndex = 1;
            this.buttonNewEnvelope.Text = "New...";
            this.buttonNewEnvelope.UseVisualStyleBackColor = true;
            this.buttonNewEnvelope.Click += new System.EventHandler(this.buttonNewEnvelope_Click);
            // 
            // dataGridViewEnvelopes
            // 
            this.dataGridViewEnvelopes.AllowUserToAddRows = false;
            this.dataGridViewEnvelopes.AllowUserToDeleteRows = false;
            this.dataGridViewEnvelopes.AllowUserToResizeRows = false;
            this.dataGridViewEnvelopes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEnvelopes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnvelopes.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewEnvelopes.MultiSelect = false;
            this.dataGridViewEnvelopes.Name = "dataGridViewEnvelopes";
            this.dataGridViewEnvelopes.ReadOnly = true;
            this.dataGridViewEnvelopes.RowHeadersVisible = false;
            this.dataGridViewEnvelopes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEnvelopes.Size = new System.Drawing.Size(240, 142);
            this.dataGridViewEnvelopes.TabIndex = 0;
            this.dataGridViewEnvelopes.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewEnvelopes_CellMouseDown);
            // 
            // buttonSaveAircraft
            // 
            this.buttonSaveAircraft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveAircraft.Location = new System.Drawing.Point(197, 227);
            this.buttonSaveAircraft.Name = "buttonSaveAircraft";
            this.buttonSaveAircraft.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveAircraft.TabIndex = 1;
            this.buttonSaveAircraft.Text = "Save";
            this.buttonSaveAircraft.UseVisualStyleBackColor = true;
            this.buttonSaveAircraft.Click += new System.EventHandler(this.buttonSaveAircraft_Click);
            // 
            // contextMenuStripDataGridViewStations
            // 
            this.contextMenuStripDataGridViewStations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEditStation,
            this.toolStripMenuItemDeleteStation});
            this.contextMenuStripDataGridViewStations.Name = "contextMenuStripDataGridViewAircraft";
            this.contextMenuStripDataGridViewStations.Size = new System.Drawing.Size(108, 48);
            // 
            // toolStripMenuItemEditStation
            // 
            this.toolStripMenuItemEditStation.Name = "toolStripMenuItemEditStation";
            this.toolStripMenuItemEditStation.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItemEditStation.Text = "Edit...";
            this.toolStripMenuItemEditStation.Click += new System.EventHandler(this.toolStripMenuItemEditStation_Click);
            // 
            // toolStripMenuItemDeleteStation
            // 
            this.toolStripMenuItemDeleteStation.Name = "toolStripMenuItemDeleteStation";
            this.toolStripMenuItemDeleteStation.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItemDeleteStation.Text = "Delete";
            this.toolStripMenuItemDeleteStation.Click += new System.EventHandler(this.toolStripMenuItemDeleteStation_Click);
            // 
            // contextMenuStripDataGridViewEnvelopes
            // 
            this.contextMenuStripDataGridViewEnvelopes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEditEnvelope,
            this.toolStripMenuItemDeleteEnvelope});
            this.contextMenuStripDataGridViewEnvelopes.Name = "contextMenuStripDataGridViewAircraft";
            this.contextMenuStripDataGridViewEnvelopes.Size = new System.Drawing.Size(108, 48);
            // 
            // toolStripMenuItemEditEnvelope
            // 
            this.toolStripMenuItemEditEnvelope.Name = "toolStripMenuItemEditEnvelope";
            this.toolStripMenuItemEditEnvelope.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItemEditEnvelope.Text = "Edit...";
            this.toolStripMenuItemEditEnvelope.Click += new System.EventHandler(this.toolStripMenuItemEditEnvelope_Click);
            // 
            // toolStripMenuItemDeleteEnvelope
            // 
            this.toolStripMenuItemDeleteEnvelope.Name = "toolStripMenuItemDeleteEnvelope";
            this.toolStripMenuItemDeleteEnvelope.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItemDeleteEnvelope.Text = "Delete";
            this.toolStripMenuItemDeleteEnvelope.Click += new System.EventHandler(this.toolStripMenuItemDeleteEnvelope_Click);
            // 
            // comboBoxLengthUnits
            // 
            this.comboBoxLengthUnits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLengthUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLengthUnits.FormattingEnabled = true;
            this.comboBoxLengthUnits.Items.AddRange(new object[] {
            "Imperial (in)",
            "Metric (cm)"});
            this.comboBoxLengthUnits.Location = new System.Drawing.Point(78, 58);
            this.comboBoxLengthUnits.Name = "comboBoxLengthUnits";
            this.comboBoxLengthUnits.Size = new System.Drawing.Size(168, 21);
            this.comboBoxLengthUnits.TabIndex = 5;
            // 
            // labelLengthUnits
            // 
            this.labelLengthUnits.AutoSize = true;
            this.labelLengthUnits.Location = new System.Drawing.Point(6, 61);
            this.labelLengthUnits.Name = "labelLengthUnits";
            this.labelLengthUnits.Size = new System.Drawing.Size(65, 13);
            this.labelLengthUnits.TabIndex = 4;
            this.labelLengthUnits.Text = "Length units";
            // 
            // labelWeightUnits
            // 
            this.labelWeightUnits.AutoSize = true;
            this.labelWeightUnits.Location = new System.Drawing.Point(6, 88);
            this.labelWeightUnits.Name = "labelWeightUnits";
            this.labelWeightUnits.Size = new System.Drawing.Size(66, 13);
            this.labelWeightUnits.TabIndex = 6;
            this.labelWeightUnits.Text = "Weight units";
            // 
            // comboBoxWeightUnits
            // 
            this.comboBoxWeightUnits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxWeightUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWeightUnits.FormattingEnabled = true;
            this.comboBoxWeightUnits.Items.AddRange(new object[] {
            "Imperial (lb)",
            "Metric (kg)"});
            this.comboBoxWeightUnits.Location = new System.Drawing.Point(78, 85);
            this.comboBoxWeightUnits.Name = "comboBoxWeightUnits";
            this.comboBoxWeightUnits.Size = new System.Drawing.Size(168, 21);
            this.comboBoxWeightUnits.TabIndex = 7;
            // 
            // EditAircraftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonSaveAircraft);
            this.Controls.Add(this.tabControlEditAircraft);
            this.Name = "EditAircraftForm";
            this.Text = "Edit Aircraft";
            this.tabControlEditAircraft.ResumeLayout(false);
            this.tabPageInformation.ResumeLayout(false);
            this.tabPageInformation.PerformLayout();
            this.tabPageStations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStations)).EndInit();
            this.tabPageEnvelopes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnvelopes)).EndInit();
            this.contextMenuStripDataGridViewStations.ResumeLayout(false);
            this.contextMenuStripDataGridViewEnvelopes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlEditAircraft;
        private System.Windows.Forms.TabPage tabPageInformation;
        private System.Windows.Forms.TabPage tabPageStations;
        private System.Windows.Forms.TabPage tabPageEnvelopes;
        private System.Windows.Forms.Button buttonSaveAircraft;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxCallsign;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelCallsign;
        private System.Windows.Forms.DataGridView dataGridViewStations;
        private System.Windows.Forms.Button buttonNewStation;
        private System.Windows.Forms.Button buttonNewEnvelope;
        private System.Windows.Forms.DataGridView dataGridViewEnvelopes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDataGridViewStations;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditStation;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteStation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDataGridViewEnvelopes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditEnvelope;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteEnvelope;
        private System.Windows.Forms.Label labelLengthUnits;
        private System.Windows.Forms.ComboBox comboBoxLengthUnits;
        private System.Windows.Forms.Label labelWeightUnits;
        private System.Windows.Forms.ComboBox comboBoxWeightUnits;
    }
}