using System;

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
            Console.WriteLine("Name: {0}", _fileInfo.Name);
            Console.WriteLine("Time: {0}", _fileInfo.CreationTime);
        }
    }
}