namespace ByteDev.FolderReader.Model
{
    internal static class IntExtensions
    {
        public static int NumberDigits(this int source)
        {
            return source.ToString().Length;
        }

        public static string ToPaddedZeroString(this int source, int length)
        {
            return source.ToString().PadLeft(length.NumberDigits(), '0');
        }
    }
}