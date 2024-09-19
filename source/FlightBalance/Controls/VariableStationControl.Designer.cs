namespace FlightBalance.Controls
{
    partial class VariableStationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelVariableStationName = new System.Windows.Forms.Label();
            this.trackBarVariableStationWeight = new System.Windows.Forms.TrackBar();
            this.labelVariableStationWeight = new System.Windows.Forms.Label();
            this.numericUpDownVariableStationWeight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVariableStationWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVariableStationWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVariableStationName
            // 
            this.labelVariableStationName.AutoSize = true;
            this.labelVariableStationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVariableStationName.Location = new System.Drawing.Point(3, 3);
            this.labelVariableStationName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.labelVariableStationName.Name = "labelVariableStationName";
            this.labelVariableStationName.Size = new System.Drawing.Size(49, 16);
            this.labelVariableStationName.TabIndex = 0;
            this.labelVariableStationName.Text = "Name";
            // 
            // trackBarVariableStationWeight
            // 
            this.trackBarVariableStationWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarVariableStationWeight.Location = new System.Drawing.Point(3, 54);
            this.trackBarVariableStationWeight.Name = "trackBarVariableStationWeight";
            this.trackBarVariableStationWeight.Size = new System.Drawing.Size(294, 45);
            this.trackBarVariableStationWeight.TabIndex = 3;
            this.trackBarVariableStationWeight.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVariableStationWeight.ValueChanged += new System.EventHandler(this.trackBarVariableStationWeight_ValueChanged);
            // 
            // labelVariableStationWeight
            // 
            this.labelVariableStationWeight.AutoSize = true;
            this.labelVariableStationWeight.Location = new System.Drawing.Point(3, 30);
            this.labelVariableStationWeight.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.labelVariableStationWeight.Name = "labelVariableStationWeight";
            this.labelVariableStationWeight.Size = new System.Drawing.Size(44, 13);
            this.labelVariableStationWeight.TabIndex = 1;
            this.labelVariableStationWeight.Text = "Weight:";
            // 
            // numericUpDownVariableStationWeight
            // 
            this.numericUpDownVariableStationWeight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownVariableStationWeight.Location = new System.Drawing.Point(100, 28);
            this.numericUpDownVariableStationWeight.Name = "numericUpDownVariableStationWeight";
            this.numericUpDownVariableStationWeight.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownVariableStationWeight.TabIndex = 2;
            this.numericUpDownVariableStationWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownVariableStationWeight.ValueChanged += new System.EventHandler(this.numericUpDownVariableStationWeight_ValueChanged);
            // 
            // VariableStationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDownVariableStationWeight);
            this.Controls.Add(this.labelVariableStationWeight);
            this.Controls.Add(this.trackBarVariableStationWeight);
            this.Controls.Add(this.labelVariableStationName);
            this.Name = "VariableStationControl";
            this.Size = new System.Drawing.Size(300, 83);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVariableStationWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVariableStationWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVariableStationName;
        private System.Windows.Forms.TrackBar trackBarVariableStationWeight;
        private System.Windows.Forms.Label labelVariableStationWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownVariableStationWeight;
    }
}
