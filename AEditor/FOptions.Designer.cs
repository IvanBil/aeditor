namespace AEditor
{
    partial class FOptions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TBPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCansel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTdArgs = new System.Windows.Forms.TextBox();
            this.tbTlinkArgs = new System.Windows.Forms.TextBox();
            this.tbTasmArgs = new System.Windows.Forms.TextBox();
            this.btnCustomize = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.chkTD = new System.Windows.Forms.CheckBox();
            this.chkLogging = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TBPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(291, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Директории";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBPath
            // 
            this.TBPath.Location = new System.Drawing.Point(8, 39);
            this.TBPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBPath.Name = "TBPath";
            this.TBPath.Size = new System.Drawing.Size(264, 23);
            this.TBPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Путь к ассемблеру, линкеру и дебаггеру:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(183, 284);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(56, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCansel
            // 
            this.btnCansel.Location = new System.Drawing.Point(244, 284);
            this.btnCansel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(56, 23);
            this.btnCansel.TabIndex = 2;
            this.btnCansel.Text = "Cansel";
            this.btnCansel.UseVisualStyleBackColor = true;
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbTdArgs);
            this.groupBox2.Controls.Add(this.tbTlinkArgs);
            this.groupBox2.Controls.Add(this.tbTasmArgs);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(9, 76);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(291, 107);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры командной строки";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Дебаггер:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Линкер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ассемблер:";
            // 
            // tbTdArgs
            // 
            this.tbTdArgs.Location = new System.Drawing.Point(95, 72);
            this.tbTdArgs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTdArgs.Name = "tbTdArgs";
            this.tbTdArgs.Size = new System.Drawing.Size(76, 23);
            this.tbTdArgs.TabIndex = 2;
            // 
            // tbTlinkArgs
            // 
            this.tbTlinkArgs.Location = new System.Drawing.Point(95, 46);
            this.tbTlinkArgs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTlinkArgs.Name = "tbTlinkArgs";
            this.tbTlinkArgs.Size = new System.Drawing.Size(76, 23);
            this.tbTlinkArgs.TabIndex = 1;
            // 
            // tbTasmArgs
            // 
            this.tbTasmArgs.Location = new System.Drawing.Point(95, 21);
            this.tbTasmArgs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTasmArgs.Name = "tbTasmArgs";
            this.tbTasmArgs.Size = new System.Drawing.Size(76, 23);
            this.tbTasmArgs.TabIndex = 0;
            // 
            // btnCustomize
            // 
            this.btnCustomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCustomize.Location = new System.Drawing.Point(9, 284);
            this.btnCustomize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCustomize.Name = "btnCustomize";
            this.btnCustomize.Size = new System.Drawing.Size(88, 23);
            this.btnCustomize.TabIndex = 4;
            this.btnCustomize.Text = "По умолчанию";
            this.btnCustomize.UseVisualStyleBackColor = true;
            this.btnCustomize.Click += new System.EventHandler(this.btnCustomize_Click);
            // 
            // btnFont
            // 
            this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFont.Location = new System.Drawing.Point(10, 240);
            this.btnFont.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(87, 29);
            this.btnFont.TabIndex = 5;
            this.btnFont.Text = "Шрифт...";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // chkTD
            // 
            this.chkTD.AutoSize = true;
            this.chkTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkTD.Location = new System.Drawing.Point(9, 188);
            this.chkTD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkTD.Name = "chkTD";
            this.chkTD.Size = new System.Drawing.Size(307, 21);
            this.chkTD.TabIndex = 6;
            this.chkTD.Text = "Автоматически запускать Turbo Debugger";
            this.chkTD.UseVisualStyleBackColor = true;
            // 
            // chkLogging
            // 
            this.chkLogging.AutoSize = true;
            this.chkLogging.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkLogging.Location = new System.Drawing.Point(9, 212);
            this.chkLogging.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkLogging.Name = "chkLogging";
            this.chkLogging.Size = new System.Drawing.Size(167, 21);
            this.chkLogging.TabIndex = 7;
            this.chkLogging.Text = "Удалять старые логи";
            this.chkLogging.UseVisualStyleBackColor = true;
            // 
            // FOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 314);
            this.Controls.Add(this.chkLogging);
            this.Controls.Add(this.chkTD);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnCustomize);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FOptions";
            this.Load += new System.EventHandler(this.FOptions_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FOptions_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTdArgs;
        private System.Windows.Forms.TextBox tbTlinkArgs;
        private System.Windows.Forms.TextBox tbTasmArgs;
        private System.Windows.Forms.Button btnCustomize;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.CheckBox chkTD;
        private System.Windows.Forms.CheckBox chkLogging;
    }
}