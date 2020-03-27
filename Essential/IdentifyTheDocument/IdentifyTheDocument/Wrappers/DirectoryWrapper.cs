using System;
using System.IO;

namespace IdentifyTheDocument.Wrappers
{
    class DirectoryWrapper : IDirectoryWrapper
    {
        public void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }

        public DateTime GetCreationTime(string path)
        {
            return Directory.GetCreationTime(path);
        }
    }
}
