using System;
using System.IO;

namespace IdentifyTheDocument.Wrappers
{
    public interface IDirectoryWrapper
    {
        void CreateDirectory(string path);

        DateTime GetCreationTime(string path);
    }
}
