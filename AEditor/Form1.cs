using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace AEditor
{
    public partial class FMain : Form
    {
        //public GlobalOptions GlOprions;
        public AsmProgram AsmPrg;//Этот класс описан в файле Program.cs
        private FErrorList ErrorList;
        /// <summary>
        /// Returns true if text was changed. Used for save dialogue and others..
        /// </summary>
        private bool IsTxtChanged;
        private bool FileIsSavedOnes;

        public bool IsTextChanged
        {
            get { return IsTxtChanged; }
            set { IsTxtChanged = value; }
        }
        /// <summary>
        /// Returns file name witout path and extension
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string GetOnlyFileName(string s)
        {
            if (s.LastIndexOf("\\") > 0)
                s = s.Remove(0, s.LastIndexOf("\\") + 1);
            s = s.Remove(s.LastIndexOf('.'), 4);
            return s;
        }

        public void SetFormText(string text)
        {
            this.Text = GetOnlyFileName(text) + '-' + GlobalOptions.Instance.DefaultThisProgramName;
        }

        public FMain(string[] args)
        {
            InitializeComponent();
            this.IsTextChanged = false;
            this.FileIsSavedOnes = false;
            //Application options default
            this.AsmPrg = new AsmProgram(Application.OpenForms.Count);
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs;
            //Check if options file exists
            if (File.Exists(Application.StartupPath + "\\" + this.AsmPrg.StandartOptionsFileName))
            {
                fs = new FileStream(this.AsmPrg.StandartOptionsFileName, FileMode.Open);
                try
                {//Loading options
                    AsmProgram.ApplicationOptions Opt = (AsmProgram.ApplicationOptions)bf.Deserialize(fs);
                    this.AsmPrg.Options = Opt;
                    fs.Close();
                }
                catch (Exception exp)
                {
                    fs.Close();
                    MessageBox.Show(exp.Message);
                }
            }
            TBProgram.Font = AsmPrg.Options.TextFont;
            //TBProgram.Styles.LineNumber.Font = AsmPrg.Options.TextFont;
            //Trying load file in editor if command prompt was used f.e. AEditor <file name>
            if (args.Length > 0)
                try
                {
                    TBProgram.Font = AsmPrg.Options.TextFont;
                    TBProgram.Text = File.ReadAllText(args[0]);// (args[0], RichTextBoxStreamType.PlainText);
                    this.FileIsSavedOnes = true;
                    this.IsTextChanged = false;
                    AsmPrg.FileName = args[0];
                    this.SetFormText(AsmPrg.FileName);
                }
                catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog Ofd = new OpenFileDialog();
            Ofd.Filter = Properties.Resources.AssemblerCode + " (*.asm)|*.asm|" + Properties.Resources.AllFiles + " (*.*)|*.*";
            Ofd.InitialDirectory = Application.StartupPath;
            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                if (this.IsTextChanged)
                {
                    if (MessageBox.Show(Properties.Resources.FileNotSavedDialog + " " + AsmPrg.FileName + " ?",
                        GlobalOptions.Instance.DefaultThisProgramName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        EventArgs ea = new EventArgs();
                        saveToolStripButton.Click += new EventHandler(saveToolStripButton_Click);
                        saveToolStripButton_Click(this, ea);
                    }
                }
                AsmPrg.FileName = Ofd.FileName;
                TBProgram.Font = AsmPrg.Options.TextFont;
                TBProgram.Text = File.ReadAllText(Ofd.FileName);// RichTextBoxStreamType.PlainText);
                this.FileIsSavedOnes = true;
                this.IsTextChanged = false;
                this.SetFormText(AsmPrg.FileName);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (!this.FileIsSavedOnes)
            {
                EventArgs ea = new EventArgs();
                saveAsToolStripMenuItem.Click += new EventHandler(saveAsToolStripMenuItem_Click);
                saveAsToolStripMenuItem_Click(this, ea);
            }
            else
            {
                File.WriteAllText(AsmPrg.FileName,TBProgram.Text);
                //TBProgram.SaveFile(AsmPrg.FileName, RichTextBoxStreamType.PlainText);
                this.IsTextChanged = false;
            }
        }

        private void FMain_Shown(object sender, EventArgs e)
        {
            this.SetFormText(AsmPrg.FileName);
            TBProgram.Refresh();
            //int LineNumber = TBProgram.GetLineFromCharIndex(TBProgram.GetFirstCharIndexOfCurrentLine()) + 1;
            //ssLinePos.Items[0].Text = LineNumber.ToString();
            //int Pos = TBProgram.SelectionStart;
            //AsmProgram.TextPos txtPos;
            //txtPos.Line = LineNumber;
            //txtPos.Pos = Pos;
            //AsmPrg.CaretPos = txtPos;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Starting another AEditor
                Process NewProgProc = new Process();
                ProcessStartInfo NewProgInfo = new ProcessStartInfo();
                NewProgInfo.FileName = Application.ExecutablePath;
                NewProgInfo.Arguments = "";
                NewProgInfo.WorkingDirectory = Application.StartupPath;
                NewProgInfo.UseShellExecute = false;
                NewProgInfo.RedirectStandardOutput = true;
                NewProgProc.StartInfo = NewProgInfo;
                NewProgInfo.WindowStyle = ProcessWindowStyle.Hidden;
                NewProgProc.Start();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }           
        }

        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            if (true)
            {
                switch (MessageBox.Show(Properties.Resources.FileNotSavedDialog + " " + AsmPrg.FileName + " ?",
                    GlobalOptions.Instance.DefaultThisProgramName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1))
                {
                    case DialogResult.Yes: EventArgs ea = new EventArgs();
                        saveToolStripButton.Click += new EventHandler(saveToolStripButton_Click);
                        saveToolStripButton_Click(this, ea);
                        break;

                    case DialogResult.Cancel: e.Cancel = true; break;

                }
            }
        }

        private void TBProgram_TextChanged(object sender, EventArgs e)
        {
            //int LineNumber = TBProgram.GetLineFromCharIndex(TBProgram.GetFirstCharIndexOfCurrentLine()) + 1;
            //ssLinePos.Items[0].Text = LineNumber.ToString();
            //int Pos = TBProgram.SelectionStart;
            //AsmProgram.TextPos txtPos;
            //txtPos.Line = LineNumber;
            //txtPos.Pos = Pos;
            //AsmPrg.CaretPos = txtPos; 
            this.IsTextChanged = true;
            StatusLabel.Text = TBProgram.Text.Length.ToString();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog Sfd = new SaveFileDialog();
            Sfd.Filter = "Тексты программ на ассемблере (*.asm)|*.asm";
            Sfd.FileName = AsmPrg.FileName;
            if (Sfd.ShowDialog() == DialogResult.OK)
            {
                AsmPrg.FileName = Sfd.FileName;
                File.WriteAllText(Sfd.FileName, TBProgram.Text);
                // TBProgram.SaveFile(Sfd.FileName, RichTextBoxStreamType.PlainText);
                this.IsTextChanged = false;
                this.FileIsSavedOnes = true;
                this.SetFormText(AsmPrg.FileName);
            }
        }

        private void TSBLink_Click(object sender, EventArgs e)
        {
            try
            {
                EventArgs ea = new EventArgs();
                saveToolStripButton.Click += new EventHandler(saveToolStripButton_Click);
                saveToolStripButton_Click(this, ea);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Clearing log
            try
            {
                if (AsmPrg.Options.ClearLog)
                {
                    //File.Create(GlobalOptions.Instance.LogPath);
                    File.WriteAllText(GlobalOptions.Instance.LogPath, "");
    
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {//Compilling in tasm
                Process TasmProc = new Process();
                ProcessStartInfo TasmInfo = new ProcessStartInfo();
                string TasmResult;
                string TasmFolder = AsmPrg.Options.Path;
                string cmdLine = "tasm.exe";
                string fileName = this.GetOnlyFileName(AsmPrg.FileName);
                string cmdArgs = @AsmPrg.Options.TasmArgs + " " + fileName + ".asm";
                TasmInfo.FileName = "cmd.exe";
                TasmInfo.Arguments = "/c " + cmdLine + cmdArgs;
                TasmInfo.WorkingDirectory = TasmFolder;
                TasmInfo.UseShellExecute = false;
                TasmInfo.RedirectStandardOutput = true;
                TasmProc.StartInfo = TasmInfo;
                TasmInfo.WindowStyle = ProcessWindowStyle.Hidden;
                TasmProc.Start();
                TasmResult = TasmProc.StandardOutput.ReadToEnd();
                TasmProc.WaitForExit();
                if (TasmResult == "") throw new Exception("Неизвестный результат выполнения команды " + cmdLine); 
                // Записываем лог
                File.AppendAllText(GlobalOptions.Instance.LogPath, TasmResult);
                // Проверка на наличие ошибок выполнения компиляции tasm.exe
                int ErrIndex1 = TasmResult.IndexOf("Error messages: ",0) + ("Error messages: ").Length;
                int ErrIndex2 = TasmResult.IndexOf('\n',ErrIndex1) - 1;
                string ErrorSearch = TasmResult.Substring(ErrIndex1, ErrIndex2 - ErrIndex1);
                try
                {
                    AsmPrg.ErrorCount = Convert.ToInt16(ErrorSearch);
                }
                catch (FormatException CastExc)
                {
                    AsmPrg.ErrorCount = 0;
                }
                if (AsmPrg.ErrorCount > 0)
                {
                    //поиск строк с сообщениями об ошибках
                    string[] Errors = new string[AsmPrg.ErrorCount];
                    ErrIndex1 = 0;
                    for (int i = 1; i <= AsmPrg.ErrorCount; i++)
                    {
                        ErrIndex1 = TasmResult.IndexOf("**", ErrIndex1);
                        ErrIndex2 = TasmResult.IndexOf('\n', ErrIndex1) - 1;
                        Errors.SetValue(TasmResult.Substring(ErrIndex1, ErrIndex2 - ErrIndex1), i - 1);
                        ErrIndex1 = ErrIndex2;
                    }

                    ErrorList.ShowErrorList(Errors);
                    ErrorList.Show();
                }
                else
                {
                    //передаем obj-файл линкеру
                    cmdLine = "tlink.exe";
                    cmdArgs = @AsmPrg.Options.TlinkArgs + " " + fileName + ".obj" + "," + fileName + ".bin";
                    TasmInfo.FileName = "cmd.exe";
                    TasmInfo.Arguments = "/c " + cmdLine + cmdArgs;
                    TasmInfo.WorkingDirectory = TasmFolder;
                    TasmInfo.UseShellExecute = false;
                    TasmInfo.RedirectStandardOutput = true;
                    TasmProc.StartInfo = TasmInfo;
                    TasmInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    TasmProc.Start();
                    TasmResult = TasmProc.StandardOutput.ReadToEnd();
                    // Записываем лог
                    File.AppendAllText(GlobalOptions.Instance.LogPath, TasmResult);
                    TasmProc.WaitForExit();
                    //передаем exe-файл дебаггеру
                    if (AsmPrg.Options.RunTD)
                    {
                        cmdLine = "td.exe";
                        cmdArgs = @AsmPrg.Options.TdArgs + " " + fileName + ".exe";
                        TasmInfo.FileName = "cmd.exe";
                        TasmInfo.Arguments = "/c " + cmdLine + cmdArgs;
                        TasmInfo.WorkingDirectory = TasmFolder;
                        TasmInfo.UseShellExecute = false;
                        TasmProc.StartInfo = TasmInfo;
                        TasmInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        TasmProc.Start();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FMain_Resize(object sender, EventArgs e)
        {
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            ErrorList = new FErrorList();
            this.AddOwnedForm(ErrorList);
            
        }

        private void TBProgram_Resize(object sender, EventArgs e)
        {
        }

        private void TBProgram_VScroll(object sender, EventArgs e)
        {
              
        }

  
        private void cutToolStripButton_Click(object sender, EventArgs e)
        {

            TBProgram.Commands.Execute(ScintillaNet.BindableCommand.Cut);
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            TBProgram.Commands.Execute(ScintillaNet.BindableCommand.Copy);
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            if (TBProgram.Clipboard.CanPaste)
            {
                TBProgram.Commands.Execute(ScintillaNet.BindableCommand.Paste);
            }
            //if (TBProgram.CanPaste(DataFormats.GetFormat(DataFormats.Rtf))|| 
            //    TBProgram.CanPaste(DataFormats.GetFormat(DataFormats.Text))) 
            //{ TBProgram.Paste(DataFormats.GetFormat("Text")); }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TBProgram.Commands.Execute(ScintillaNet.BindableCommand.SelectAll);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FOptions Options = new FOptions();
            this.AddOwnedForm(Options);
            Options.Show();
        }

        private void TBProgram_MouseClick(object sender, MouseEventArgs e)
        {
            //int LineNumber = TBProgram.GetLineFromCharIndex(TBProgram.GetFirstCharIndexOfCurrentLine()) + 1;
            //ssLinePos.Items[0].Text = LineNumber.ToString();
            //int Pos = TBProgram.SelectionStart;
            //AsmProgram.TextPos txtPos;
            //txtPos.Line = LineNumber;
            //txtPos.Pos = Pos;
            //AsmPrg.CaretPos = txtPos;
        }

        private void TBProgram_KeyDown(object sender, KeyEventArgs e)
        {
            //AsmProgram.TextPos txtPos;
            //txtPos = AsmPrg.CaretPos;
            //switch (e.KeyCode)
            //{
            //    case Keys.Up: if(txtPos.Line > 1) { txtPos.Line--; } break;
            //    case Keys.Down: if (txtPos.Line < TBProgram.Lines.Length ){ txtPos.Line++; } break;
            //}
            //AsmPrg.CaretPos = txtPos;
            //ssLinePos.Items[0].Text = AsmPrg.CaretPos.Line.ToString();
          
        }

        private void TBProgram_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TBProgram.UndoRedo.CanUndo)
            {
                TBProgram.Commands.Execute(ScintillaNet.BindableCommand.Undo);
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TBProgram.UndoRedo.CanRedo) 
            { 
                TBProgram.Commands.Execute(ScintillaNet.BindableCommand.Redo); 
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.TxtFindDialogue.Show();
            TBProgram.FindReplace.Window.ShowDialog();
            //TBProgram.FindReplace.Window.Show();
        }

        private void tsmiErrorMessages_Click(object sender, EventArgs e)
        {
            ErrorList.Show();
            ErrorList.WindowState = FormWindowState.Normal;
        }

        private void linkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TSBLink.Click+=new EventHandler(TSBLink_Click);
            TSBLink_Click(sender, e);
        }

        private void logфайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Flog Logtext = new Flog();
                Logtext.Show();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.ProductName + " version: " + Application.ProductVersion + Environment.NewLine +
                "Assembler code editing tool." + Environment.NewLine + 
                Application.ProductName + " site: http://aeditor.codeplex.com/" + Environment.NewLine +
                "Please, report bugs and ask questions to:" + Environment.NewLine +
                ("http://aeditor.codeplex.com/Thread/List.aspx"),
                "About " + Application.ProductName);

            //TODO: Translate to Russian and show links as hyperlinks
        }

        private void onlineDocumentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://aeditor.codeplex.com/documentation");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

    }

}