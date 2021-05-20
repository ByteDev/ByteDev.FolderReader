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
            this.showCounterPrefixCheckBox = new System.Windows.Forms.CheckBox();
            this.textWrapCheckBox = new System.Windows.Forms.CheckBox();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.showFileSuffixCheckBox = new System.Windows.Forms.CheckBox();
            this.showFileSizeCheckBox = new System.Windows.Forms.CheckBox();
            this.showFullPathCheckBox = new System.Windows.Forms.CheckBox();
            this.suffixTextBox = new System.Windows.Forms.TextBox();
            this.browseCommandButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.showFoldersCheckBox = new System.Windows.Forms.CheckBox();
            this.copyToClipboardButton = new System.Windows.Forms.Button();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.showFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.folderDelimiterCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // showCounterPrefixCheckBox
            // 
            this.showCounterPrefixCheckBox.Location = new System.Drawing.Point(795, 49);
            this.showCounterPrefixCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showCounterPrefixCheckBox.Name = "showCounterPrefixCheckBox";
            this.showCounterPrefixCheckBox.Size = new System.Drawing.Size(131, 24);
            this.showCounterPrefixCheckBox.TabIndex = 21;
            this.showCounterPrefixCheckBox.Text = "File Counter";
            this.showCounterPrefixCheckBox.CheckedChanged += new System.EventHandler(this.showCounterPrefixCheckBox_CheckedChanged);
            // 
            // textWrapCheckBox
            // 
            this.textWrapCheckBox.Location = new System.Drawing.Point(112, 49);
            this.textWrapCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textWrapCheckBox.Name = "textWrapCheckBox";
            this.textWrapCheckBox.Size = new System.Drawing.Size(120, 24);
            this.textWrapCheckBox.TabIndex = 20;
            this.textWrapCheckBox.Text = "Text Wrap";
            this.textWrapCheckBox.CheckedChanged += new System.EventHandler(this.textWrapCheckBox_CheckedChanged);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 689);
            this.statusBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(958, 34);
            this.statusBar.TabIndex = 19;
            // 
            // showFileSuffixCheckBox
            // 
            this.showFileSuffixCheckBox.Checked = true;
            this.showFileSuffixCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showFileSuffixCheckBox.Location = new System.Drawing.Point(560, 49);
            this.showFileSuffixCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showFileSuffixCheckBox.Name = "showFileSuffixCheckBox";
            this.showFileSuffixCheckBox.Size = new System.Drawing.Size(120, 24);
            this.showFileSuffixCheckBox.TabIndex = 18;
            this.showFileSuffixCheckBox.Text = "File Suffix";
            this.showFileSuffixCheckBox.CheckedChanged += new System.EventHandler(this.showFileSuffixCheckBox_CheckedChanged);
            // 
            // showFileSizeCheckBox
            // 
            this.showFileSizeCheckBox.Location = new System.Drawing.Point(685, 49);
            this.showFileSizeCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showFileSizeCheckBox.Name = "showFileSizeCheckBox";
            this.showFileSizeCheckBox.Size = new System.Drawing.Size(108, 24);
            this.showFileSizeCheckBox.TabIndex = 17;
            this.showFileSizeCheckBox.Text = "File Size";
            this.showFileSizeCheckBox.CheckedChanged += new System.EventHandler(this.showFileSizeCheckBox_CheckedChanged);
            // 
            // showFullPathCheckBox
            // 
            this.showFullPathCheckBox.Location = new System.Drawing.Point(12, 49);
            this.showFullPathCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showFullPathCheckBox.Name = "showFullPathCheckBox";
            this.showFullPathCheckBox.Size = new System.Drawing.Size(108, 24);
            this.showFullPathCheckBox.TabIndex = 16;
            this.showFullPathCheckBox.Text = "Full Path";
            this.showFullPathCheckBox.CheckedChanged += new System.EventHandler(this.showFullPathCheckBox_CheckedChanged);
            // 
            // suffixTextBox
            // 
            this.suffixTextBox.Location = new System.Drawing.Point(744, 6);
            this.suffixTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.suffixTextBox.Name = "suffixTextBox";
            this.suffixTextBox.Size = new System.Drawing.Size(70, 26);
            this.suffixTextBox.TabIndex = 15;
            this.suffixTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.suffixTextBox_KeyPress);
            // 
            // browseCommandButton
            // 
            this.browseCommandButton.Location = new System.Drawing.Point(828, 6);
            this.browseCommandButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.browseCommandButton.Name = "browseCommandButton";
            this.browseCommandButton.Size = new System.Drawing.Size(112, 35);
            this.browseCommandButton.TabIndex = 14;
            this.browseCommandButton.Text = "Browse";
            this.browseCommandButton.Click += new System.EventHandler(this.browseCommandButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox.Location = new System.Drawing.Point(12, 92);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputTextBox.Size = new System.Drawing.Size(918, 532);
            this.outputTextBox.TabIndex = 13;
            this.outputTextBox.WordWrap = false;
            // 
            // folderTextBox
            // 
            this.folderTextBox.Location = new System.Drawing.Point(12, 6);
            this.folderTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(718, 26);
            this.folderTextBox.TabIndex = 12;
            this.folderTextBox.Text = "C:\\";
            this.folderTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.folderTextBox_KeyPress);
            // 
            // showFoldersCheckBox
            // 
            this.showFoldersCheckBox.AutoSize = true;
            this.showFoldersCheckBox.Location = new System.Drawing.Point(231, 49);
            this.showFoldersCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showFoldersCheckBox.Name = "showFoldersCheckBox";
            this.showFoldersCheckBox.Size = new System.Drawing.Size(88, 24);
            this.showFoldersCheckBox.TabIndex = 22;
            this.showFoldersCheckBox.Text = "Folders";
            this.showFoldersCheckBox.UseVisualStyleBackColor = true;
            this.showFoldersCheckBox.CheckedChanged += new System.EventHandler(this.showFoldersCheckBox_CheckedChanged);
            // 
            // copyToClipboardButton
            // 
            this.copyToClipboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyToClipboardButton.Location = new System.Drawing.Point(824, 635);
            this.copyToClipboardButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.copyToClipboardButton.Name = "copyToClipboardButton";
            this.copyToClipboardButton.Size = new System.Drawing.Size(112, 35);
            this.copyToClipboardButton.TabIndex = 23;
            this.copyToClipboardButton.Text = "Copy";
            this.copyToClipboardButton.UseVisualStyleBackColor = true;
            this.copyToClipboardButton.Click += new System.EventHandler(this.copyToClipboardButton_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveAsButton.Location = new System.Drawing.Point(704, 635);
            this.saveAsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(112, 35);
            this.saveAsButton.TabIndex = 24;
            this.saveAsButton.Text = "Save As";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // showFilesCheckBox
            // 
            this.showFilesCheckBox.AutoSize = true;
            this.showFilesCheckBox.Checked = true;
            this.showFilesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showFilesCheckBox.Location = new System.Drawing.Point(480, 49);
            this.showFilesCheckBox.Name = "showFilesCheckBox";
            this.showFilesCheckBox.Size = new System.Drawing.Size(68, 24);
            this.showFilesCheckBox.TabIndex = 25;
            this.showFilesCheckBox.Text = "Files";
            this.showFilesCheckBox.UseVisualStyleBackColor = true;
            this.showFilesCheckBox.CheckedChanged += new System.EventHandler(this.showFilesCheckBox_CheckedChanged);
            // 
            // folderDelimiterCheckBox
            // 
            this.folderDelimiterCheckBox.AutoSize = true;
            this.folderDelimiterCheckBox.Checked = true;
            this.folderDelimiterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.folderDelimiterCheckBox.Location = new System.Drawing.Point(325, 49);
            this.folderDelimiterCheckBox.Name = "folderDelimiterCheckBox";
            this.folderDelimiterCheckBox.Size = new System.Drawing.Size(146, 24);
            this.folderDelimiterCheckBox.TabIndex = 26;
            this.folderDelimiterCheckBox.Text = "Folder Delimiter";
            this.folderDelimiterCheckBox.UseVisualStyleBackColor = true;
            this.folderDelimiterCheckBox.CheckedChanged += new System.EventHandler(this.folderDelimiterCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 723);
            this.Controls.Add(this.folderDelimiterCheckBox);
            this.Controls.Add(this.showFilesCheckBox);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.copyToClipboardButton);
            this.Controls.Add(this.showFoldersCheckBox);
            this.Controls.Add(this.showCounterPrefixCheckBox);
            this.Controls.Add(this.textWrapCheckBox);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.showFileSuffixCheckBox);
            this.Controls.Add(this.showFileSizeCheckBox);
            this.Controls.Add(this.showFullPathCheckBox);
            this.Controls.Add(this.suffixTextBox);
            this.Controls.Add(this.browseCommandButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.folderTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox showCounterPrefixCheckBox;
		private System.Windows.Forms.CheckBox textWrapCheckBox;
		private System.Windows.Forms.StatusBar statusBar;
		private System.Windows.Forms.CheckBox showFileSuffixCheckBox;
		private System.Windows.Forms.CheckBox showFileSizeCheckBox;
		private System.Windows.Forms.CheckBox showFullPathCheckBox;
		private System.Windows.Forms.TextBox suffixTextBox;
		private System.Windows.Forms.Button browseCommandButton;
		private System.Windows.Forms.TextBox outputTextBox;
		private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.CheckBox showFoldersCheckBox;
        private System.Windows.Forms.Button copyToClipboardButton;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.CheckBox showFilesCheckBox;
        private System.Windows.Forms.CheckBox folderDelimiterCheckBox;
    }
}