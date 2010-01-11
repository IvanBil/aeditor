using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;
using System.Drawing;
using System.Text.RegularExpressions;

namespace AEditor
{
    /// <summary>
    /// Defines parameters of document opened in editor and options for compiling program and text input
    /// </summary>
    public class AsmProgram
    {
        /// <summary>
        /// Containes user-defined options 
        /// </summary>
        [Serializable]
        public class ApplicationOptions
        {
            private string path;
            private string tasmArgs;
            private string tlinkArgs;
            private string tdArgs;
            private bool runTD;
            private bool clearLog;

            public bool ClearLog
            {
                get { return clearLog; }
                set { clearLog = value; }
            }

            public bool RunTD
            {
                get { return runTD; }
                set { runTD = value; }
            }
            private Font textFont;

            public Font TextFont
            {
                get { return textFont; }
                set { textFont = value; }
            }

            public string TlinkArgs
            {
                get { return tlinkArgs; }
                set { tlinkArgs = value; }
            }

            public string TdArgs
            {
                get { return tdArgs; }
                set { tdArgs = value; }
            }

            public string TasmArgs
            {
                get { return tasmArgs; }
                set { tasmArgs = value; }
            }
            /// <summary>
            /// path to the .asm file without name of file
            /// </summary>
            public string Path
            {
                get { return path; }
                set { path = value; }
            }

            public ApplicationOptions()
            {
                this.Path = Application.StartupPath + "\\tasm";
                this.TasmArgs = " /zi /l";
                this.TlinkArgs = " /v";
                this.TdArgs = " ";
                this.RunTD = true;
                this.ClearLog = true;
                textFont = new Font(FontFamily.GenericSansSerif,8);    
            }
        }
        /// <summary>
        /// Structure used for position of caret
        /// </summary>
        public struct TextPos 
        { 
            public int Line; 
            /// <summary>
            /// Position from start of the text
            /// </summary>
            public int Pos;
        }
        public ApplicationOptions Options;
        private const string standartFileName = "Noname";
        private const string standartOptionsFileName = "Options.dat";
        private string fileName;
        /// <summary>
        /// Number of currently runned AEditors (used for making default file name f.e. noname1,noname5 etc)
        /// </summary>
        private int progCount;
        /// <summary>
        /// Number of errors that were found by tasm.exe
        /// </summary>
        private int errorCount;
        private TextPos caretPos;
        public TextPos CaretPos
        {
            get { return caretPos; }
            set { caretPos = value; }
        }
       
        public int ErrorCount
        {
            get { return errorCount; }
            set { errorCount = value; }
        }

        public string StandartOptionsFileName
        {
            get { return standartOptionsFileName; }
        } 

        public string StandartFileName
        {
            get { return standartFileName; }
        } 

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
   
        public int ProgCount
        {
            get { return progCount; }
        }
        public AsmProgram(int progCount)
        {
            this.progCount = progCount;
            this.fileName = standartFileName + progCount.ToString() + ".asm";
           // this.LogPath = Application.StartupPath + @"\" + AEditor.GlobalOptions.DefaultThisProgramName + ".log";
            this.Options = new ApplicationOptions();
        }

    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FMain(args));
        }
    }
}