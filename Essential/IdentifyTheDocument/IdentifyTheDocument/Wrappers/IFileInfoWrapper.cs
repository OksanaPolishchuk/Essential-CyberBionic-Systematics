using System;

namespace IdentifyTheDocument.Wrappers
{
    public interface IFileInfoWrapper
    {
        string Name { get; }
        string Extension { get; }
        DateTime CreationTime { get; }
    }
}