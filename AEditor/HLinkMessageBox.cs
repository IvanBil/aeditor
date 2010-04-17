using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace AEditor
{
    public partial class HLinkMessageBox : Form
    {
        public HLinkMessageBox()
        {
            InitializeComponent();
        }

        public HLinkMessageBox(string Text, string Header):this()
        {
            this.Text = Header;
            this.AutoSize = true;
            this.rtbMessage.AutoSize = true;
            this.rtbMessage.Text = Text;
            //this.rtbMessage.Height
        }

        public static void Show(string Text, string Header)
        {
            HLinkMessageBox msg = new HLinkMessageBox(Text, Header);
            msg.Show();
        }

        private void fAbout_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtbMessage_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                Process.Start(e.LinkText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
