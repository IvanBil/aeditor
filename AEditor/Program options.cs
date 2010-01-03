using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AEditor
{
    class GlobalOptions
    {
        private static GlobalOptions instance;
        private const string defaultThisProgramName = "AEditor";
        public string DefaultThisProgramName
        {
            get { return defaultThisProgramName; }
        }

        private string logPath;
        public string LogPath
        {
            get { return logPath; }
            set { logPath = value; }
        }
        protected GlobalOptions()
        {
            this.LogPath = Application.StartupPath + @"\" + DefaultThisProgramName + ".log";
        }
        /// <summary>
        /// Returns object. If no object was created then creates it.
        /// </summary>
        public static GlobalOptions Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new GlobalOptions();
                }
                return GlobalOptions.instance; 
            }
        }

    }
}
