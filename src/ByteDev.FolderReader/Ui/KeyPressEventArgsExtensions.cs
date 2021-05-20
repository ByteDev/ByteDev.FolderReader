using System.Windows.Forms;

namespace ByteDev.FolderReader.Ui
{
    public static class KeyPressEventArgsExtensions
    {
        public static bool IsEnter(this KeyPressEventArgs source)
        {
            return source.KeyChar.ToString() == "\r";
        }
    }
}
