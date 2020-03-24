using System.IO;

namespace IdentifyTheDocument
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
    }
}