namespace FlightBalance.Forms
{
    partial class MainForm
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
            this.groupBoxAircraft = new System.Windows.Forms.GroupBox();
            this.dataGridViewAircraft = new System.Windows.Forms.DataGridView();
            this.buttonNewAircraft = new System.Windows.Forms.Button();
            this.contextMenuStripDataGridViewAircraft = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemNewFromThis = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditAircraft = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteAircraft = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxAircraft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAircraft)).BeginInit();
            this.contextMenuStripDataGridViewAircraft.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAircraft
            // 
            this.groupBoxAircraft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAircraft.Controls.Add(this.dataGridViewAircraft);
            this.groupBoxAircraft.Controls.Add(this.buttonNewAircraft);
            this.groupBoxAircraft.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAircraft.Name = "groupBoxAircraft";
            this.groupBoxAircraft.Size = new System.Drawing.Size(360, 338);
            this.groupBoxAircraft.TabIndex = 0;
            this.groupBoxAircraft.TabStop = false;
            this.groupBoxAircraft.Text = "Aircraft";
            // 
            // dataGridViewAircraft
            // 
            this.dataGridViewAircraft.AllowUserToAddRows = false;
            this.dataGridViewAircraft.AllowUserToDeleteRows = false;
            this.dataGridViewAircraft.AllowUserToResizeRows = false;
            this.dataGridViewAircraft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAircraft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAircraft.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewAircraft.MultiSelect = false;
            this.dataGridViewAircraft.Name = "dataGridViewAircraft";
            this.dataGridViewAircraft.ReadOnly = true;
            this.dataGridViewAircraft.RowHeadersVisible = false;
            this.dataGridViewAircraft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAircraft.Size = new System.Drawing.Size(348, 284);
            this.dataGridViewAircraft.TabIndex = 1;
            this.dataGridViewAircraft.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAircraft_CellDoubleClick);
            this.dataGridViewAircraft.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAircraft_CellMouseDown);
            // 
            // buttonNewAircraft
            // 
            this.buttonNewAircraft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewAircraft.Location = new System.Drawing.Point(279, 309);
            this.buttonNewAircraft.Name = "buttonNewAircraft";
            this.buttonNewAircraft.Size = new System.Drawing.Size(75, 23);
            this.buttonNewAircraft.TabIndex = 2;
            this.buttonNewAircraft.Text = "New...";
            this.buttonNewAircraft.UseVisualStyleBackColor = true;
            this.buttonNewAircraft.Click += new System.EventHandler(this.buttonNewAircraft_Click);
            // 
            // contextMenuStripDataGridViewAircraft
            // 
            this.contextMenuStripDataGridViewAircraft.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNewFromThis,
            this.toolStripMenuItemEditAircraft,
            this.toolStripMenuItemDeleteAircraft});
            this.contextMenuStripDataGridViewAircraft.Name = "contextMenuStripDataGridViewAircraft";
            this.contextMenuStripDataGridViewAircraft.Size = new System.Drawing.Size(159, 92);
            // 
            // toolStripMenuItemNewFromThis
            // 
            this.toolStripMenuItemNewFromThis.Name = "toolStripMenuItemNewFromThis";
            this.toolStripMenuItemNewFromThis.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItemNewFromThis.Text = "New from this...";
            this.toolStripMenuItemNewFromThis.Click += new System.EventHandler(this.toolStripMenuItemNewFromThis_Click);
            // 
            // toolStripMenuItemEditAircraft
            // 
            this.toolStripMenuItemEditAircraft.Name = "toolStripMenuItemEditAircraft";
            this.toolStripMenuItemEditAircraft.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItemEditAircraft.Text = "Edit...";
            this.toolStripMenuItemEditAircraft.Click += new System.EventHandler(this.toolStripMenuItemEditAircraft_Click);
            // 
            // toolStripMenuItemDeleteAircraft
            // 
            this.toolStripMenuItemDeleteAircraft.Name = "toolStripMenuItemDeleteAircraft";
            this.toolStripMenuItemDeleteAircraft.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItemDeleteAircraft.Text = "Delete";
            this.toolStripMenuItemDeleteAircraft.Click += new System.EventHandler(this.toolStripMenuItemDeleteAircraft_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.groupBoxAircraft);
            this.Name = "MainForm";
            this.Text = "FlightBalance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBoxAircraft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAircraft)).EndInit();
            this.contextMenuStripDataGridViewAircraft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAircraft;
        private System.Windows.Forms.Button buttonNewAircraft;
        private System.Windows.Forms.DataGridView dataGridViewAircraft;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDataGridViewAircraft;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditAircraft;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteAircraft;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNewFromThis;
    }
}
