using System;
using System.IO;
using System.Windows.Forms;

namespace ByteDev.FolderReader.Ui
{
    public class FileDialog
    {
        public static string SaveTextFile()
        {
            string systemDrivePath = Path.GetPathRoot(Environment.SystemDirectory);

            var dialog = new SaveFileDialog
            {
                InitialDirectory = systemDrivePath,
                FileName = "output.txt",
                Filter = @"Text files (*.txt)|*.txt|All files (*.*)|*.*",
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return null;
        }
    }
}