namespace AEditor
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.linkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiErrorMessages = new System.Windows.Forms.ToolStripMenuItem();
            this.logÙ‡ÈÎToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineDocumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBProgram = new ScintillaNet.Scintilla();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBLink = new System.Windows.Forms.ToolStripButton();
            this.ToolPanel = new System.Windows.Forms.ToolStrip();
            this.ssLinePos = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBProgram)).BeginInit();
            this.ToolPanel.SuspendLayout();
            this.ssLinePos.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.AccessibleDescription = null;
            this.MainMenu.AccessibleName = null;
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.BackgroundImage = null;
            this.MainMenu.Font = null;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.tsmView,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Name = "MainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.AccessibleDescription = null;
            this.fileToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.BackgroundImage = null;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.linkToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.AccessibleDescription = null;
            this.newToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            this.newToolStripMenuItem.BackgroundImage = null;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.AccessibleDescription = null;
            this.openToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.BackgroundImage = null;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.AccessibleDescription = null;
            this.toolStripSeparator.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
            this.toolStripSeparator.Name = "toolStripSeparator";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.AccessibleDescription = null;
            this.saveToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.BackgroundImage = null;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.AccessibleDescription = null;
            this.saveAsToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            this.saveAsToolStripMenuItem.BackgroundImage = null;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AccessibleDescription = null;
            this.toolStripSeparator1.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // linkToolStripMenuItem
            // 
            this.linkToolStripMenuItem.AccessibleDescription = null;
            this.linkToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.linkToolStripMenuItem, "linkToolStripMenuItem");
            this.linkToolStripMenuItem.BackgroundImage = null;
            this.linkToolStripMenuItem.Name = "linkToolStripMenuItem";
            this.linkToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.linkToolStripMenuItem.Click += new System.EventHandler(this.linkToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AccessibleDescription = null;
            this.toolStripSeparator2.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AccessibleDescription = null;
            this.exitToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.BackgroundImage = null;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.AccessibleDescription = null;
            this.editToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.BackgroundImage = null;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.findToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.AccessibleDescription = null;
            this.undoToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.undoToolStripMenuItem, "undoToolStripMenuItem");
            this.undoToolStripMenuItem.BackgroundImage = null;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.AccessibleDescription = null;
            this.redoToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.redoToolStripMenuItem, "redoToolStripMenuItem");
            this.redoToolStripMenuItem.BackgroundImage = null;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AccessibleDescription = null;
            this.toolStripSeparator3.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.AccessibleDescription = null;
            this.cutToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.cutToolStripMenuItem, "cutToolStripMenuItem");
            this.cutToolStripMenuItem.BackgroundImage = null;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.AccessibleDescription = null;
            this.copyToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            this.copyToolStripMenuItem.BackgroundImage = null;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.AccessibleDescription = null;
            this.pasteToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.pasteToolStripMenuItem, "pasteToolStripMenuItem");
            this.pasteToolStripMenuItem.BackgroundImage = null;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AccessibleDescription = null;
            this.toolStripSeparator4.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.AccessibleDescription = null;
            this.findToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.findToolStripMenuItem, "findToolStripMenuItem");
            this.findToolStripMenuItem.BackgroundImage = null;
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.AccessibleDescription = null;
            this.selectAllToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.selectAllToolStripMenuItem, "selectAllToolStripMenuItem");
            this.selectAllToolStripMenuItem.BackgroundImage = null;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // tsmView
            // 
            this.tsmView.AccessibleDescription = null;
            this.tsmView.AccessibleName = null;
            resources.ApplyResources(this.tsmView, "tsmView");
            this.tsmView.BackgroundImage = null;
            this.tsmView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiErrorMessages,
            this.logÙ‡ÈÎToolStripMenuItem});
            this.tsmView.Name = "tsmView";
            this.tsmView.ShortcutKeyDisplayString = null;
            // 
            // tsmiErrorMessages
            // 
            this.tsmiErrorMessages.AccessibleDescription = null;
            this.tsmiErrorMessages.AccessibleName = null;
            resources.ApplyResources(this.tsmiErrorMessages, "tsmiErrorMessages");
            this.tsmiErrorMessages.BackgroundImage = null;
            this.tsmiErrorMessages.Name = "tsmiErrorMessages";
            this.tsmiErrorMessages.ShortcutKeyDisplayString = null;
            this.tsmiErrorMessages.Click += new System.EventHandler(this.tsmiErrorMessages_Click);
            // 
            // logÙ‡ÈÎToolStripMenuItem
            // 
            this.logÙ‡ÈÎToolStripMenuItem.AccessibleDescription = null;
            this.logÙ‡ÈÎToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.logÙ‡ÈÎToolStripMenuItem, "logÙ‡ÈÎToolStripMenuItem");
            this.logÙ‡ÈÎToolStripMenuItem.BackgroundImage = null;
            this.logÙ‡ÈÎToolStripMenuItem.Name = "logÙ‡ÈÎToolStripMenuItem";
            this.logÙ‡ÈÎToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.logÙ‡ÈÎToolStripMenuItem.Click += new System.EventHandler(this.logÙ‡ÈÎToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.AccessibleDescription = null;
            this.toolsToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            this.toolsToolStripMenuItem.BackgroundImage = null;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.AccessibleDescription = null;
            this.helpToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.BackgroundImage = null;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineDocumentationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // onlineDocumentationToolStripMenuItem
            // 
            this.onlineDocumentationToolStripMenuItem.AccessibleDescription = null;
            this.onlineDocumentationToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.onlineDocumentationToolStripMenuItem, "onlineDocumentationToolStripMenuItem");
            this.onlineDocumentationToolStripMenuItem.BackgroundImage = null;
            this.onlineDocumentationToolStripMenuItem.Name = "onlineDocumentationToolStripMenuItem";
            this.onlineDocumentationToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.onlineDocumentationToolStripMenuItem.Click += new System.EventHandler(this.onlineDocumentationToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.AccessibleDescription = null;
            this.aboutToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.BackgroundImage = null;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = null;
            this.panel1.AccessibleName = null;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackgroundImage = null;
            this.panel1.Controls.Add(this.TBProgram);
            this.panel1.Font = null;
            this.panel1.Name = "panel1";
            // 
            // TBProgram
            // 
            this.TBProgram.AccessibleDescription = null;
            this.TBProgram.AccessibleName = null;
            resources.ApplyResources(this.TBProgram, "TBProgram");
            this.TBProgram.BackgroundImage = null;
            this.TBProgram.ConfigurationManager.Language = "asm";
            this.TBProgram.Lexing.Lexer = ScintillaNet.Lexer.Asm;
            this.TBProgram.Lexing.LexerName = "asm";
            this.TBProgram.Lexing.LineCommentPrefix = "";
            this.TBProgram.Lexing.StreamCommentPrefix = "";
            this.TBProgram.Lexing.StreamCommentSufix = "";
            this.TBProgram.Lexing.WordChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_¿‡¡·¬‚√„ƒ‰≈Â®∏∆Ê«Á" +
                "»Ë…È ÍÀÎÃÏ";
            this.TBProgram.Margins.Margin0.AutoToggleMarkerNumber = 1;
            this.TBProgram.Margins.Margin0.Width = 20;
            this.TBProgram.Margins.Margin1.Width = 5;
            this.TBProgram.Name = "TBProgram";
            this.TBProgram.Styles.BraceBad.FontName = "Verdana";
            this.TBProgram.Styles.BraceLight.FontName = "Verdana";
            this.TBProgram.Styles.ControlChar.FontName = "Verdana";
            this.TBProgram.Styles.Default.FontName = "Verdana";
            this.TBProgram.Styles.IndentGuide.FontName = "Verdana";
            this.TBProgram.Styles.LastPredefined.FontName = "Verdana";
            this.TBProgram.Styles.LineNumber.FontName = "Verdana";
            this.TBProgram.Styles.Max.FontName = "Verdana";
            this.TBProgram.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBProgram_KeyPress);
            this.TBProgram.TextChanged += new System.EventHandler<System.EventArgs>(this.TBProgram_TextChanged);
            this.TBProgram.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TBProgram_MouseClick);
            this.TBProgram.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBProgram_KeyDown);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.AccessibleDescription = null;
            this.newToolStripButton.AccessibleName = null;
            resources.ApplyResources(this.newToolStripButton, "newToolStripButton");
            this.newToolStripButton.BackgroundImage = null;
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.AccessibleDescription = null;
            this.openToolStripButton.AccessibleName = null;
            resources.ApplyResources(this.openToolStripButton, "openToolStripButton");
            this.openToolStripButton.BackgroundImage = null;
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.AccessibleDescription = null;
            this.saveToolStripButton.AccessibleName = null;
            resources.ApplyResources(this.saveToolStripButton, "saveToolStripButton");
            this.saveToolStripButton.BackgroundImage = null;
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.AccessibleDescription = null;
            this.toolStripSeparator6.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.AccessibleDescription = null;
            this.cutToolStripButton.AccessibleName = null;
            resources.ApplyResources(this.cutToolStripButton, "cutToolStripButton");
            this.cutToolStripButton.BackgroundImage = null;
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.AccessibleDescription = null;
            this.copyToolStripButton.AccessibleName = null;
            resources.ApplyResources(this.copyToolStripButton, "copyToolStripButton");
            this.copyToolStripButton.BackgroundImage = null;
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.AccessibleDescription = null;
            this.pasteToolStripButton.AccessibleName = null;
            resources.ApplyResources(this.pasteToolStripButton, "pasteToolStripButton");
            this.pasteToolStripButton.BackgroundImage = null;
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.AccessibleDescription = null;
            this.toolStripSeparator7.AccessibleName = null;
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            // 
            // TSBLink
            // 
            this.TSBLink.AccessibleDescription = null;
            this.TSBLink.AccessibleName = null;
            resources.ApplyResources(this.TSBLink, "TSBLink");
            this.TSBLink.BackgroundImage = null;
            this.TSBLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSBLink.Name = "TSBLink";
            this.TSBLink.Click += new System.EventHandler(this.TSBLink_Click);
            // 
            // ToolPanel
            // 
            this.ToolPanel.AccessibleDescription = null;
            this.ToolPanel.AccessibleName = null;
            resources.ApplyResources(this.ToolPanel, "ToolPanel");
            this.ToolPanel.BackgroundImage = null;
            this.ToolPanel.Font = null;
            this.ToolPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator7,
            this.TSBLink});
            this.ToolPanel.Name = "ToolPanel";
            // 
            // ssLinePos
            // 
            this.ssLinePos.AccessibleDescription = null;
            this.ssLinePos.AccessibleName = null;
            resources.ApplyResources(this.ssLinePos, "ssLinePos");
            this.ssLinePos.BackgroundImage = null;
            this.ssLinePos.Font = null;
            this.ssLinePos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.ssLinePos.Name = "ssLinePos";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AccessibleDescription = null;
            this.StatusLabel.AccessibleName = null;
            resources.ApplyResources(this.StatusLabel, "StatusLabel");
            this.StatusLabel.BackgroundImage = null;
            this.StatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StatusLabel.Name = "StatusLabel";
            // 
            // FMain
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ssLinePos);
            this.Controls.Add(this.ToolPanel);
            this.Controls.Add(this.MainMenu);
            this.Font = null;
            this.Icon = null;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "FMain";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.Shown += new System.EventHandler(this.FMain_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMain_FormClosing);
            this.Resize += new System.EventHandler(this.FMain_Resize);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TBProgram)).EndInit();
            this.ToolPanel.ResumeLayout(false);
            this.ToolPanel.PerformLayout();
            this.ssLinePos.ResumeLayout(false);
            this.ssLinePos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton TSBLink;
        private System.Windows.Forms.ToolStrip ToolPanel;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        public System.Windows.Forms.StatusStrip ssLinePos;
        private System.Windows.Forms.ToolStripMenuItem tsmView;
        private System.Windows.Forms.ToolStripMenuItem tsmiErrorMessages;
        private System.Windows.Forms.ToolStripMenuItem linkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logÙ‡ÈÎToolStripMenuItem;
        public ScintillaNet.Scintilla TBProgram;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineDocumentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

    }
}

