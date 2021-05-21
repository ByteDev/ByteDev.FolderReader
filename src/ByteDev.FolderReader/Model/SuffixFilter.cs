namespace ByteDev.FolderReader.Model
{
    public class SuffixFilter
    {
        private readonly string _text;

        public SuffixFilter(string text)
        {
            _text = text.StartsWith("*.") ? text.Substring(2) : text;
        }

        public string Text => string.IsNullOrEmpty(_text) ? "*" : _text;

        public override string ToString()
        {
            return Text;
        }
    }
}