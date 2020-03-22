using System;

namespace IdentifyTheDocument
{
    public interface IFileInfoWrapper
    {
        string Name { get; }
        DateTime CreationTime { get; }
    }
}