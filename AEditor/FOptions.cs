using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace AEditor
{
    public partial class FOptions : Form
    {
        public FOptions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                TBPath.Text = FBD.SelectedPath;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //saving options
            FMain Form1 = this.Owner as FMain;
            Form1.AsmPrg.Options.Path = TBPath.Text;
            Form1.AsmPrg.Options.TasmArgs = tbTasmArgs.Text;
            Form1.AsmPrg.Options.TlinkArgs = tbTlinkArgs.Text;
            Form1.AsmPrg.Options.TdArgs = tbTdArgs.Text;
            Form1.AsmPrg.Options.TextFont = Form1.TBProgram.Font;
            Form1.AsmPrg.Options.RunTD = chkTD.Checked;
            Form1.AsmPrg.Options.ClearLog = chkLogging.Checked;
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs;
            try
            {
                fs = new FileStream(Application.StartupPath + "\\" + Form1.AsmPrg.StandartOptionsFileName, FileMode.Create);
                bf.Serialize(fs, Form1.AsmPrg.Options);
                fs.Close();
                this.Close();
            }
            catch (IOException exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FOptions_Load(object sender, EventArgs e)
        {
            //writing options in their fields
            FMain Form1 = this.Owner as FMain;
            TBPath.Text = Form1.AsmPrg.Options.Path;
            tbTasmArgs.Text = Form1.AsmPrg.Options.TasmArgs;
            tbTlinkArgs.Text = Form1.AsmPrg.Options.TlinkArgs;
            tbTdArgs.Text = Form1.AsmPrg.Options.TdArgs;
            chkTD.Checked = Form1.AsmPrg.Options.RunTD;
            chkLogging.Checked = Form1.AsmPrg.Options.ClearLog;
        }

        private void btnCustomize_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите это сделать?", "Сброс к заводским настройкам", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FMain Form1 = this.Owner as FMain;
                Form1.AsmPrg.Options = new AsmProgram.ApplicationOptions();
                TBPath.Text = Form1.AsmPrg.Options.Path;
                tbTasmArgs.Text = Form1.AsmPrg.Options.TasmArgs;
                tbTlinkArgs.Text = Form1.AsmPrg.Options.TlinkArgs;
                tbTdArgs.Text = Form1.AsmPrg.Options.TdArgs;
                chkTD.Checked = false;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FMain Form1 = this.Owner as FMain;
            FontDialog FD = new FontDialog();
            FD.Font = Form1.AsmPrg.Options.TextFont;
            if (FD.ShowDialog() == DialogResult.OK)
            {
                Form1.AsmPrg.Options.TextFont = FD.Font;
                // Form1.TBProgram.Commands.Execute(ScintillaNet.BindableCommand.SelectAll);
                Form1.TBProgram.UseFont = true;
                Form1.TBProgram.Font = FD.Font;
                // Form1.TBProgram.ResetFont();

                //Form1.TBProgram.Commands.Execute(ScintillaNet.BindableCommand.SelectionDuplicate);
            }
        }

        private void FOptions_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Activate();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}