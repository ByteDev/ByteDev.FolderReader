using System.Windows.Forms;

namespace ByteDev.FolderReader.Ui
{
    public static class StatusBarExtensions
    {
        public static void SetStatus(this StatusBar source, string message)
        {
            source.Text = message;
        }

        public static void SetStatusError(this StatusBar source, string message)
        {
            source.Text = message;
        }

        public static void SetCountStatus(this StatusBar source, int fileCount, int folderCount)
        {
            string message;

            if (folderCount == 1)
                message = "1 folder";
            else
                message = $"{folderCount} folders";

            if (fileCount == 1)
                message += " / 1 file";
            else
                message += $" / {fileCount} files";
            
            SetStatus(source, message);
        }

        public static void Clear(this StatusBar source)
        {
            SetStatus(source, string.Empty);
        }
    }
}