namespace ByteDev.FolderReader
{
	partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.suffixTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderDelimiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSuffixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileHashMD5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputSaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 610);
            this.statusBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(678, 34);
            this.statusBar.TabIndex = 19;
            // 
            // suffixTextBox
            // 
            this.suffixTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.suffixTextBox.Location = new System.Drawing.Point(98, 74);
            this.suffixTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.suffixTextBox.Name = "suffixTextBox";
            this.suffixTextBox.Size = new System.Drawing.Size(75, 26);
            this.suffixTextBox.TabIndex = 1;
            this.suffixTextBox.Text = "*.*";
            this.suffixTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.suffixTextBox_KeyPress);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox.Location = new System.Drawing.Point(13, 110);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputTextBox.Size = new System.Drawing.Size(652, 490);
            this.outputTextBox.TabIndex = 3;
            this.outputTextBox.WordWrap = false;
            // 
            // folderTextBox
            // 
            this.folderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderTextBox.Location = new System.Drawing.Point(13, 38);
            this.folderTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(652, 26);
            this.folderTextBox.TabIndex = 0;
            this.folderTextBox.Text = "C:\\";
            this.folderTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.folderTextBox_KeyPress);
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.outputToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(678, 33);
            this.menuStrip.TabIndex = 27;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullPathToolStripMenuItem,
            this.textWrapToolStripMenuItem,
            this.foldersToolStripMenuItem,
            this.folderDelimiterToolStripMenuItem,
            this.filesToolStripMenuItem,
            this.fileSuffixToolStripMenuItem,
            this.fileSizeToolStripMenuItem,
            this.fileCounterToolStripMenuItem,
            this.fileHashMD5ToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // fullPathToolStripMenuItem
            // 
            this.fullPathToolStripMenuItem.CheckOnClick = true;
            this.fullPathToolStripMenuItem.Name = "fullPathToolStripMenuItem";
            this.fullPathToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.fullPathToolStripMenuItem.Text = "Full Path";
            this.fullPathToolStripMenuItem.Click += new System.EventHandler(this.fullPathToolStripMenuItem_Click);
            // 
            // textWrapToolStripMenuItem
            // 
            this.textWrapToolStripMenuItem.CheckOnClick = true;
            this.textWrapToolStripMenuItem.Name = "textWrapToolStripMenuItem";
            this.textWrapToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.textWrapToolStripMenuItem.Text = "Text Wrap";
            this.textWrapToolStripMenuItem.Click += new System.EventHandler(this.textWrapToolStripMenuItem_Click);
            // 
            // foldersToolStripMenuItem
            // 
            this.foldersToolStripMenuItem.CheckOnClick = true;
            this.foldersToolStripMenuItem.Name = "foldersToolStripMenuItem";
            this.foldersToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.foldersToolStripMenuItem.Text = "Folders";
            this.foldersToolStripMenuItem.Click += new System.EventHandler(this.foldersToolStripMenuItem_Click);
            // 
            // folderDelimiterToolStripMenuItem
            // 
            this.folderDelimiterToolStripMenuItem.Checked = true;
            this.folderDelimiterToolStripMenuItem.CheckOnClick = true;
            this.folderDelimiterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.folderDelimiterToolStripMenuItem.Name = "folderDelimiterToolStripMenuItem";
            this.folderDelimiterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.folderDelimiterToolStripMenuItem.Text = "Folder Delimiter";
            this.folderDelimiterToolStripMenuItem.Click += new System.EventHandler(this.folderDelimiterToolStripMenuItem_Click);
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.Checked = true;
            this.filesToolStripMenuItem.CheckOnClick = true;
            this.filesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.filesToolStripMenuItem.Text = "Files";
            this.filesToolStripMenuItem.Click += new System.EventHandler(this.filesToolStripMenuItem_Click);
            // 
            // fileSuffixToolStripMenuItem
            // 
            this.fileSuffixToolStripMenuItem.Checked = true;
            this.fileSuffixToolStripMenuItem.CheckOnClick = true;
            this.fileSuffixToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fileSuffixToolStripMenuItem.Name = "fileSuffixToolStripMenuItem";
            this.fileSuffixToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.fileSuffixToolStripMenuItem.Text = "File Suffix";
            this.fileSuffixToolStripMenuItem.Click += new System.EventHandler(this.fileSuffixToolStripMenuItem_Click);
            // 
            // fileSizeToolStripMenuItem
            // 
            this.fileSizeToolStripMenuItem.CheckOnClick = true;
            this.fileSizeToolStripMenuItem.Name = "fileSizeToolStripMenuItem";
            this.fileSizeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.fileSizeToolStripMenuItem.Text = "File Size";
            this.fileSizeToolStripMenuItem.Click += new System.EventHandler(this.fileSizeToolStripMenuItem_Click);
            // 
            // fileCounterToolStripMenuItem
            // 
            this.fileCounterToolStripMenuItem.CheckOnClick = true;
            this.fileCounterToolStripMenuItem.Name = "fileCounterToolStripMenuItem";
            this.fileCounterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.fileCounterToolStripMenuItem.Text = "File Counter";
            this.fileCounterToolStripMenuItem.Click += new System.EventHandler(this.fileCounterToolStripMenuItem_Click);
            // 
            // fileHashMD5ToolStripMenuItem
            // 
            this.fileHashMD5ToolStripMenuItem.CheckOnClick = true;
            this.fileHashMD5ToolStripMenuItem.Name = "fileHashMD5ToolStripMenuItem";
            this.fileHashMD5ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.fileHashMD5ToolStripMenuItem.Text = "File - Hash (MD5)";
            this.fileHashMD5ToolStripMenuItem.Click += new System.EventHandler(this.fileHashMD5ToolStripMenuItem_Click);
            // 
            // outputToolStripMenuItem
            // 
            this.outputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputCopyToolStripMenuItem,
            this.outputSaveAsToolStripMenuItem});
            this.outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            this.outputToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.outputToolStripMenuItem.Text = "&Output";
            // 
            // outputCopyToolStripMenuItem
            // 
            this.outputCopyToolStripMenuItem.Name = "outputCopyToolStripMenuItem";
            this.outputCopyToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.outputCopyToolStripMenuItem.Text = "&Copy";
            this.outputCopyToolStripMenuItem.Click += new System.EventHandler(this.outputCopyToolStripMenuItem_Click);
            // 
            // outputSaveAsToolStripMenuItem
            // 
            this.outputSaveAsToolStripMenuItem.Name = "outputSaveAsToolStripMenuItem";
            this.outputSaveAsToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.outputSaveAsToolStripMenuItem.Text = "Save &As";
            this.outputSaveAsToolStripMenuItem.Click += new System.EventHandler(this.outputSaveAsToolStripMenuItem_Click);
            // 
            // hashTextBox
            // 
            this.hashTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hashTextBox.Location = new System.Drawing.Point(280, 74);
            this.hashTextBox.Name = "hashTextBox";
            this.hashTextBox.Size = new System.Drawing.Size(385, 26);
            this.hashTextBox.TabIndex = 2;
            this.hashTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hashTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "MD5 Match:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Extension:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 644);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hashTextBox);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.suffixTextBox);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.folderTextBox);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.StatusBar statusBar;
		private System.Windows.Forms.TextBox suffixTextBox;
		private System.Windows.Forms.TextBox outputTextBox;
		private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foldersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderDelimiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSuffixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileCounterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputSaveAsToolStripMenuItem;
        private System.Windows.Forms.TextBox hashTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem fileHashMD5ToolStripMenuItem;
    }
}