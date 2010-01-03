using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AEditor
{
    public partial class FErrorList : Form
    {
        public FErrorList()
        {
            InitializeComponent();
            GVErrorList.Columns[0].Width = GVErrorList.Width;
        }
        /// <summary>
        /// Fills table of errors
        /// </summary>
        /// <param name="Errors"></param>
        public void ShowErrorList(string[] Errors)
        {
            GVErrorList.Rows.Clear();           
            foreach (string s in Errors)
            {
                GVErrorList.Rows.Add(s);
            }
        }

        private void FErrorList_Load(object sender, EventArgs e)
        {
           
        }

        private void GVErrorList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FMain Form1 = ((this.Owner) as FMain);
            //выдел€ем из текста €чейки номер строки с ошибкой
            DataGridView DGV = sender as DataGridView;
            string ErrorString = DGV.CurrentCell.Value as string;
            int index1 = ErrorString.IndexOf('(') + 1;
            int index2 = ErrorString.IndexOf(')');
            int LineNumber;
            try
            {
                LineNumber = Convert.ToInt16(ErrorString.Substring(index1, index2 - index1));
                //выдел€ем в тексте программы эту строку
                Form1.TBProgram.GoTo.Line(LineNumber - 1);
                Form1.TBProgram.Lines.Current.Select();
                Form1.TBProgram.Focus();
                //Now we save position of caret 
                //int LN = Form1.TBProgram.GetLineFromCharIndex(Form1.TBProgram.GetFirstCharIndexOfCurrentLine()) + 1;
                //Form1.ssLinePos.Items[0].Text = LN.ToString();
                //int Pos = Form1.TBProgram.SelectionStart;
                //AsmProgram.TextPos txtPos;
                //txtPos.Line = LN;
                //txtPos.Pos = Pos;
                //Form1.AsmPrg.CaretPos = txtPos;
            }
            catch (IndexOutOfRangeException) { }
            catch (ArgumentOutOfRangeException) { }
            catch (InvalidCastException) { }
            catch (FormatException) { }
        }

        private void FErrorList_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hide form instead of closing
            this.Visible = false;
            e.Cancel = true;
            this.Owner.Activate();
        }

        private void FErrorList_ResizeBegin(object sender, EventArgs e)
        {
            
        }

        private void FErrorList_Resize(object sender, EventArgs e)
        {
            GVErrorList.Columns[0].Width = GVErrorList.Width;
        }

        private void GVErrorList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();    
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void GVErrorList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //Making context menu and showing it
                DataGridViewCell CurrentCell = (sender as DataGridView).CurrentCell;        
                ContextMenuStrip GoTo = new ContextMenuStrip();
                ToolStripMenuItem goToToolStripMenuItem = new ToolStripMenuItem();
                goToToolStripMenuItem.Name = "goToToolStripMenuItem";
                goToToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
                goToToolStripMenuItem.Text = "Go To";
                GoTo.Items.AddRange(new ToolStripItem[] {goToToolStripMenuItem});
                GoTo.Size = new System.Drawing.Size(153, 48);
                GoTo.SuspendLayout();
                GoTo.ResumeLayout(false);
                GoTo.MouseClick += new MouseEventHandler(GoTo_MouseClick);
                CurrentCell.ContextMenuStrip = GoTo;
                CurrentCell.ContextMenuStrip.Show(sender as DataGridView,e.X,e.Y + GVErrorList.CurrentRow.Index*GVErrorList.CurrentRow.Height);
 
            }
        }

        void GoTo_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

   
    }
}