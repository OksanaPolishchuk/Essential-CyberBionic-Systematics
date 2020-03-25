using System;
using System.IO;
using System.Text;
using IdentifyTheDocument.Wrappers;

namespace IdentifyTheDocument
{
    public class AbstractHandler
    {
        private readonly IFileWrapper _file;
        private readonly IFileInfoWrapper _fileInfo;
        private readonly IConsoleWrapper _console;

        public AbstractHandler(IFileWrapper file,
            IFileInfoWrapper fileInfo,
            IConsoleWrapper console)
        {
            _file = file;
            _fileInfo = fileInfo;
            _console = console;
        }

        public virtual void Open()
        {
            _console.WriteLine($"Name: {_fileInfo.Name}");
            _console.WriteLine($"Time: {_fileInfo.CreationTime}");
            _console.WriteLine($"Extension: {_fileInfo.Extension}");
        }

        public virtual void Change(string contents)
        {
            _file.AppendAllText(_fileInfo.FullName, contents);
            var text = _file.ReadAllText(_fileInfo.FullName);
            _console.WriteLine(text);
        }

        public virtual void Create()
        {
            var folder = @"C:\Work2";
            DirectoryInfo d = Directory.CreateDirectory(folder);
            Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(folder));

            //string path = @"C:\Work2\Test.txt";
            //string text = "0";
            File.WriteAllText(path, text, Encoding.UTF8);
        }
    }
}