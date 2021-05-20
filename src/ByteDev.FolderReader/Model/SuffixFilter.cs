namespace ByteDev.FolderReader.Model
{
    public class SuffixFilter
    {
        private readonly string _text;

        public SuffixFilter(string text)
        {
            if (text.StartsWith("*."))
            {
                text = text.Substring(2);
            }
            _text = text;
        }

        public string Text
        {
            get
            {
                if (string.IsNullOrEmpty(_text))
                {
                    return "*";
                }
                return _text;
            }
        }

        public override string ToString()
        {
            return Text;
        }
    }
}