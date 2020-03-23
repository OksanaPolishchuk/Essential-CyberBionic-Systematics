using System;
using System.IO;
using System.Text;
using IdentifyTheDocument.Wrappers;

namespace IdentifyTheDocument
{
    public class AbstractHandler
    {
        private readonly IFileInfoWrapper _fileInfo;

        public AbstractHandler(IFileInfoWrapper fileInfo)
        {
            _fileInfo = fileInfo;
        }

        public virtual void Open()
        {
            Console.WriteLine($"Name: {_fileInfo.Name}");
            Console.WriteLine("Time: {0}", _fileInfo.CreationTime);
            Console.WriteLine("Extension: {0}", _fileInfo.Extension);
        }
    }
}