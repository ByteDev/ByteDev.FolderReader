using System.IO;
using ByteDev.Io;

namespace ByteDev.FolderReader.Model
{
    internal class FileDetail
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
            string name = _fileInfo.Name;

            if (_displayOptions.ShowFullPath)
                name = _fileInfo.FullName;

            if (!_displayOptions.ShowFileSuffix)
                name = Path.ChangeExtension(name, null);

            if (_displayOptions.ShowFileSize)
            {
                var fileSize = new FileSize(_fileInfo.Length);
                name += " (" + fileSize.ReadableSize + ")";
            }

            if (_displayOptions.ShowCounterPrefix)
                name = _fileNumber.ToPaddedZeroString(_totalFiles) + ": " + name;

            return name;
        }
    }
}