using System;
using System.IO;

namespace IdentifyTheDocument
{
    public class FileInfoWrapper : IFileInfoWrapper
    {
        private readonly FileInfo _fileInfo;

        public FileInfoWrapper(string path)
        {
            _fileInfo = new FileInfo(path);
        }

        public string Name => _fileInfo.Name;

        public DateTime CreationTime => _fileInfo.CreationTime;
    }
}