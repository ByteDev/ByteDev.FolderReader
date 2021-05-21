using System.IO;

namespace ByteDev.FolderReader.Model
{
    internal class FolderDetail
    {
        private readonly DirectoryInfo _directoryInfo;
        private readonly bool _useDelimiter;

        public FolderDetail(DirectoryInfo directoryInfo, bool useDelimiter)
        {
            _directoryInfo = directoryInfo;
            _useDelimiter = useDelimiter;
        }

        public override string ToString()
        {
            if (_useDelimiter)
                return $"[{_directoryInfo.Name}]";

            return _directoryInfo.Name;
        }
    }
}