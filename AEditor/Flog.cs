using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AEditor
{
    public partial class Flog : Form
    {
        public Flog()
        {
            InitializeComponent();
        }

        private void Flog_Load(object sender, EventArgs e)
        {
            try
            {
                tbLog.Text = File.ReadAllText(GlobalOptions.Instance.LogPath);
                this.Text = (Application.OpenForms[0] as FMain).AsmPrg.FileName + " - Log";

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Flog_VisibleChanged(object sender, EventArgs e)
        {
        }
    }
}