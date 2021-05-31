using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ByteDev.FolderReader.Model;
using ByteDev.FolderReader.Ui;
using ByteDev.WinForms;
using FileDialog = ByteDev.FolderReader.Ui.FileDialog;
using SuffixFilter = ByteDev.FolderReader.Model.SuffixFilter;

namespace ByteDev.FolderReader
{
	public partial class MainForm : Form
    {
	    public MainForm()
		{
			InitializeComponent();
            SetWindowText();
		}

	    private void SetWindowText()
	    {
	        Text = @"Folder Reader " + Application.ProductVersion;
	    }

	    private FileDisplayOptions CreateFileDisplayOptions()
	    {
	        return new FileDisplayOptions
	        {
	            ShowFullPath = fullPathToolStripMenuItem.Checked,
	            ShowFileSize = fileSizeToolStripMenuItem.Checked,
	            ShowFileSuffix = fileSuffixToolStripMenuItem.Checked,
	            ShowCounterPrefix = fileCounterToolStripMenuItem.Checked,
                ShowFileMd5 = fileHashMD5ToolStripMenuItem.Checked
            };
	    }

	    private void PrintFoldersAndFiles()
	    {
            ClearOutputAndStatus();

	        if (!Directory.Exists(folderTextBox.Text))
	        {
	            statusBar.SetStatusError("Folder does not exist.");
                return;
	        }

	        var folderCount = 0;

            if (foldersToolStripMenuItem.Checked)
	        {
                folderCount = PrintFolders(folderTextBox.Text);
	        }

            var fileCount = 0;

            if (filesToolStripMenuItem.Checked)
            {
                var options = CreateFileDisplayOptions();
                var suffixFilter = new SuffixFilter(suffixTextBox.Text);

                fileCount = PrintFiles(folderTextBox.Text, suffixFilter, options);
            }

            statusBar.SetCountStatus(fileCount, folderCount);
        }

	    private int PrintFolders(string folderPath)
	    {
            var dirInfo = new DirectoryInfo(folderPath);

	        var folderCount = 0;

	        foreach (var directoryInfo in dirInfo.GetDirectories())
	        {
                var folderDetail = new FolderDetail(directoryInfo, folderDelimiterToolStripMenuItem.Checked);

                outputTextBox.PrintLine(folderDetail.ToString());
	            folderCount++;
	        }

	        return folderCount;
	    }

	    private int PrintFiles(string folderPath, SuffixFilter suffixFilter, FileDisplayOptions fileDisplayOptions)
		{
            statusBar.SetStatus("Performing search...");

			var dirInfo = new DirectoryInfo(folderPath);

            var fileCount = 0;
            
            var fileHash = hashTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(fileHash))
            {
                var matches = ChecksumService.GetMd5Matches(folderTextBox.Text, fileHash);

                foreach (var match in matches)
                {
                    var fileDetail = new FileDetail(new FileInfo(match), fileDisplayOptions, fileCount + 1, matches.Count);

                    outputTextBox.PrintLine(fileDetail.ToString());
                    fileCount++;
                }
            }
            else
            {
                var fileInfos = dirInfo.GetFiles("*." + suffixFilter);

                foreach (var fileInfo in fileInfos)
                {
                    var fileDetail = new FileDetail(fileInfo, fileDisplayOptions, fileCount + 1, fileInfos.Length);

                    outputTextBox.PrintLine(fileDetail.ToString());
                    fileCount++;
                }
            }

			return fileCount;
		}

        private void ClearOutputAndStatus()
		{
			outputTextBox.Clear();
            statusBar.Clear();
		}

        private void CopyOutputToClipboard()
        {
            Clipboard.SetText(outputTextBox.Text);
            statusBar.SetStatus("Copied to clipboard");
        }

        private void SaveOutput()
        {
            var filePath = FileDialog.SaveTextFile();

            if (!string.IsNullOrEmpty(filePath))
            {
                SaveOutputToFile(filePath);
            }
        }

        private void SaveOutputToFile(string filePath)
        {
            using (var sw = new StreamWriter(filePath))
            {
                sw.Write(outputTextBox.Text);
            }
        }
        
        #region Event Handlers

        private void MainForm_Load(object sender, EventArgs e)
		{
		    MinimumSize = new Size(Width, Height);
            PrintFoldersAndFiles();
		}

		private void folderTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.IsEnter())
			{
				PrintFoldersAndFiles();
			}
		}

		private void suffixTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.IsEnter())
			{
				PrintFoldersAndFiles();
			}
		}

        private void hashTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.IsEnter())
            {
                PrintFoldersAndFiles();
            }
        }

        #endregion

        #region Menu - File - Event Handlers

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderTextBox.Text = WinForms.Dialogs.FolderDialog.SelectFolder(folderTextBox.Text);
            
            PrintFoldersAndFiles();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }

        #endregion

        #region Menu - View - Event Handlers

        private void fullPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintFoldersAndFiles();
        }

        private void textWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputTextBox.WordWrap = textWrapToolStripMenuItem.Checked;
        }

        private void foldersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintFoldersAndFiles();
        }

        private void folderDelimiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintFoldersAndFiles();
        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintFoldersAndFiles();
        }

        private void fileSuffixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintFoldersAndFiles();
        }

        private void fileSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintFoldersAndFiles();
        }

        private void fileCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintFoldersAndFiles();
        }

        private void fileHashMD5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintFoldersAndFiles();
        }

        #endregion

        #region Menu - Output - Event Handlers

        private void outputCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyOutputToClipboard();
        }

        private void outputSaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveOutput();
        }

        #endregion
    }
}
