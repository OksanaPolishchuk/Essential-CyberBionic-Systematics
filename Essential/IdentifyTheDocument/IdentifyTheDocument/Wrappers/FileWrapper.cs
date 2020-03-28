using System.IO;

namespace IdentifyTheDocument.Wrappers
{
    public class FileWrapper : IFileWrapper
    {
        public void AppendAllText(string path, string contents)
        {
            File.AppendAllText(path, contents);
        }

        public string ReadAllText(string path)
        {
            var text = File.ReadAllText(path);
            return text;
        }

        public void Move(string sourceFileName,string destFileName)
        {
            File.Move(sourceFileName,  destFileName);
        }
    }
}