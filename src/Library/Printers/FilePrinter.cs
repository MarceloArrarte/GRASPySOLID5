using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        private string _filename;

        public FilePrinter(string filename) {
            this._filename = filename;
        }

        public void Print(IPrintable objectToPrint)
        {
            File.WriteAllText(this._filename, objectToPrint.GetTextToPrint());
        }
    }
}