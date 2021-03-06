using System.IO;
using ByteDev.Io;
using ByteDev.ValueTypes;

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

            if (_displayOptions.ShowFileMd5)
                name += " -> " + ChecksumService.GetMd5(_fileInfo.FullName);

            if (_displayOptions.ShowCounterPrefix)
                name = _fileNumber.ToStringZeroPadded(_totalFiles.GetDigits()) + ": " + name;

            return name;
        }
    }
}