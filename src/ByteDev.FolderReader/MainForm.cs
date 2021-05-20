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
	            ShowFullPath = showFullPathCheckBox.Checked,
	            ShowFileSize = showFileSizeCheckBox.Checked,
	            ShowFileSuffix = showFileSuffixCheckBox.Checked,
	            ShowCounterPrefix = showCounterPrefixCheckBox.Checked
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

            if (showFoldersCheckBox.Checked)
	        {
                folderCount = PrintFolders(folderTextBox.Text);
	        }

            var fileCount = 0;

            if (showFilesCheckBox.Checked)
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
                var folderDetail = new FolderDetail(directoryInfo, folderDelimiterCheckBox.Checked);

                outputTextBox.PrintLine(folderDetail.ToString());
	            folderCount++;
	        }

	        return folderCount;
	    }

	    private int PrintFiles(string folderPath, SuffixFilter suffixFilter, FileDisplayOptions fileDisplayOptions)
		{
			var dirInfo = new DirectoryInfo(folderPath);

            var fileCount = 0;

	        var fileInfos = dirInfo.GetFiles("*." + suffixFilter);
            
	        foreach (var fileInfo in fileInfos)
			{
                var fileDetail = new FileDetail(fileInfo, fileDisplayOptions, fileCount + 1, fileInfos.Length);

                outputTextBox.PrintLine(fileDetail.ToString());
				fileCount++;
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

	    private void browseCommandButton_Click(object sender, EventArgs e)
	    {
	        folderTextBox.Text = WinForms.Dialogs.FolderDialog.SelectFolder(folderTextBox.Text);
            
            PrintFoldersAndFiles();
		}

	    private void textWrapCheckBox_CheckedChanged(object sender, EventArgs e)
	    {
	        outputTextBox.WordWrap = textWrapCheckBox.Checked;
	    }

        private void folderDelimiterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PrintFoldersAndFiles();
        }

        private void showFilesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PrintFoldersAndFiles();
        }

	    private void showCounterPrefixCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			PrintFoldersAndFiles();
		}

	    private void showFoldersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PrintFoldersAndFiles();
        }

	    private void showFileSuffixCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			PrintFoldersAndFiles();
		}

		private void showFileSizeCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			PrintFoldersAndFiles();
		}

		private void showFullPathCheckBox_CheckedChanged(object sender, EventArgs e)
		{
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

        private void copyToClipboardButton_Click(object sender, EventArgs e)
        {
            CopyOutputToClipboard();
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            SaveOutput();
        }

        #endregion
    }
}
