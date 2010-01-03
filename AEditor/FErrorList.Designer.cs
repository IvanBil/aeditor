namespace AEditor
{
    partial class FErrorList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GVErrorList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GVErrorList)).BeginInit();
            this.SuspendLayout();
            // 
            // GVErrorList
            // 
            this.GVErrorList.AllowUserToAddRows = false;
            this.GVErrorList.AllowUserToDeleteRows = false;
            this.GVErrorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GVErrorList.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.GVErrorList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GVErrorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVErrorList.ColumnHeadersVisible = false;
            this.GVErrorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.GVErrorList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GVErrorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GVErrorList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GVErrorList.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GVErrorList.Location = new System.Drawing.Point(0, 0);
            this.GVErrorList.MultiSelect = false;
            this.GVErrorList.Name = "GVErrorList";
            this.GVErrorList.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVErrorList.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GVErrorList.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVErrorList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GVErrorList.RowTemplate.Height = 24;
            this.GVErrorList.RowTemplate.ReadOnly = true;
            this.GVErrorList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GVErrorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GVErrorList.Size = new System.Drawing.Size(526, 242);
            this.GVErrorList.TabIndex = 0;
            this.GVErrorList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVErrorList_CellContentDoubleClick);
            this.GVErrorList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GVErrorList_CellMouseClick);
            this.GVErrorList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVErrorList_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 5;
            // 
            // FErrorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 242);
            this.Controls.Add(this.GVErrorList);
            this.MaximizeBox = false;
            this.Name = "FErrorList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Error list";
            this.ResizeBegin += new System.EventHandler(this.FErrorList_ResizeBegin);
            this.Resize += new System.EventHandler(this.FErrorList_Resize);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FErrorList_FormClosing);
            this.Load += new System.EventHandler(this.FErrorList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVErrorList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GVErrorList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;

    }
}