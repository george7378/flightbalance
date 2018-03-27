namespace FlightBalance.Forms
{
    partial class EditStationForm
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
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonSaveStation = new System.Windows.Forms.Button();
            this.dataGridViewFields = new System.Windows.Forms.DataGridView();
            this.groupBoxFields = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFields)).BeginInit();
            this.groupBoxFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(12, 15);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "Type";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Fixed",
            "Variable"});
            this.comboBoxType.Location = new System.Drawing.Point(49, 12);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(223, 21);
            this.comboBoxType.TabIndex = 1;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // buttonSaveStation
            // 
            this.buttonSaveStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveStation.Location = new System.Drawing.Point(197, 227);
            this.buttonSaveStation.Name = "buttonSaveStation";
            this.buttonSaveStation.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveStation.TabIndex = 4;
            this.buttonSaveStation.Text = "Save";
            this.buttonSaveStation.UseVisualStyleBackColor = true;
            this.buttonSaveStation.Click += new System.EventHandler(this.buttonSaveStation_Click);
            // 
            // dataGridViewFields
            // 
            this.dataGridViewFields.AllowUserToAddRows = false;
            this.dataGridViewFields.AllowUserToDeleteRows = false;
            this.dataGridViewFields.AllowUserToResizeRows = false;
            this.dataGridViewFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFields.ColumnHeadersVisible = false;
            this.dataGridViewFields.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewFields.MultiSelect = false;
            this.dataGridViewFields.Name = "dataGridViewFields";
            this.dataGridViewFields.RowHeadersVisible = false;
            this.dataGridViewFields.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewFields.Size = new System.Drawing.Size(248, 157);
            this.dataGridViewFields.TabIndex = 3;
            // 
            // groupBoxFields
            // 
            this.groupBoxFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFields.Controls.Add(this.dataGridViewFields);
            this.groupBoxFields.Location = new System.Drawing.Point(12, 39);
            this.groupBoxFields.Name = "groupBoxFields";
            this.groupBoxFields.Size = new System.Drawing.Size(260, 182);
            this.groupBoxFields.TabIndex = 2;
            this.groupBoxFields.TabStop = false;
            this.groupBoxFields.Text = "Fields";
            // 
            // EditStationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBoxFields);
            this.Controls.Add(this.buttonSaveStation);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelType);
            this.Name = "EditStationForm";
            this.Text = "Edit Station";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFields)).EndInit();
            this.groupBoxFields.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonSaveStation;
        private System.Windows.Forms.DataGridView dataGridViewFields;
        private System.Windows.Forms.GroupBox groupBoxFields;
    }
}