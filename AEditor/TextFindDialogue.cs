using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AEditor
{
    public partial class TextFindDialogue : Form
    {
        /// <summary>
        /// Start position for search
        /// </summary>
        private int searchPos;

        public int SearchPos
        {
            get { return searchPos; }
            set { searchPos = value; }
        }

        public TextFindDialogue()
        {
            InitializeComponent();
            this.SearchPos = 0;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //if (cbxStringToFind.Items.IndexOf(cbxStringToFind.Text) == -1)
            //{
            //    cbxStringToFind.Items.Insert(0, cbxStringToFind.Text);
            //}
            //FMain Form1 = this.Owner as FMain;
            //ScintillaNet.SearchFlags Options = ScintillaNet.SearchFlags.Empty;
            ////RichTextBoxFinds Options = RichTextBoxFinds.None;
            //int SearchRes;
            //if (chkCaseSensitive.Checked) Options &= ScintillaNet.SearchFlags.MatchCase;
            //if (chkWholeWord.Checked) Options &= ScintillaNet.SearchFlags.WholeWord;
            //Form1.TBProgram.FindReplace.
            //if (rbtnUp.Checked)
            //{
            //    int tmpRes = -1;
            //    SearchPos = 0;
            //    do
            //    {
            //        SearchRes = tmpRes;
            //        Form1.TBProgram.SearchFlags = ScintillaNet.SearchFlags.
            //        Form1.TBProgram.Commands.Execute(ScintillaNet.BindableCommand.FindNext);
            //        tmpRes = Form1.TBProgram.Find(cbxStringToFind.Text, this.SearchPos, Options);
            //        if (tmpRes != -1)
            //        {
            //            SearchPos = tmpRes + 1;
            //        }
            //    } while ((tmpRes < Form1.AsmPrg.CaretPos.Pos - 1) && (tmpRes != -1));
            //}
            //else
            //{
            //    SearchPos = Form1.AsmPrg.CaretPos.Pos + 1;
            //    SearchRes = Form1.TBProgram.Find(cbxStringToFind.Text, this.SearchPos, Options);
            //}

            //if (SearchRes != -1)
            //{
            //    SearchPos = SearchRes;
            //    Form1.TBProgram.Focus();
            //    int LineNumber = Form1.TBProgram.GetLineFromCharIndex(Form1.TBProgram.GetFirstCharIndexOfCurrentLine()) + 1;
            //    Form1.ssLinePos.Items[0].Text = LineNumber.ToString();
            //    AsmProgram.TextPos txtPos;
            //    txtPos.Line = LineNumber;
            //    txtPos.Pos = SearchPos;
            //    Form1.AsmPrg.CaretPos = txtPos;
            //}
            //else
            //{
            //    MessageBox.Show("Строка \"" + cbxStringToFind.Text + "\" не найдена!", "Поиск");
            //}

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Activate();
        }

        private void TextFindDialogue_Load(object sender, EventArgs e)
        {

        }

        private void TextFindDialogue_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            this.Owner.Activate();
        }
    }
}