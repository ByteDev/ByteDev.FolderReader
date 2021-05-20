using System.IO;
using ByteDev.Io;

namespace ByteDev.FolderReader.Model
{
    public class FileDetail
    {
        private readonly FileInfo _fileInfo;
        private readonly FileDisplayOptions _displayOptions;
        private readonly int _fileNumber;
        private readonly int _totalFiles;

        public FileDetail(FileInfo fileInfo, FileDisplayOptions displayOptions, int fileNumber, int totalFiles)
        {
            _fileInfo = fileInfo;
            _displayOptions = displayOptions;
            _fileNumber = fileNumber;
            _totalFiles = totalFiles;
        }

        public override string ToString()
        {
            string s = _fileInfo.Name;

            if (_displayOptions.ShowFullPath)
            {
                s = _fileInfo.FullName;
            }

            if (!_displayOptions.ShowFileSuffix)
            {
                s = Path.ChangeExtension(s, null);
            }

            if (_displayOptions.ShowFileSize)
            {
                var fileSize = new FileSize(_fileInfo.Length);
                s += " (" + fileSize.ReadableSize + ")";
            }

            if (_displayOptions.ShowCounterPrefix)
            {
                s = _fileNumber.ToString().PadLeft(NumberDigits(_totalFiles), '0') + ": " + s;
            }

            return s;
        }

        private int NumberDigits(long i)
        {
            return i.ToString().Length;
        }
    }
}