﻿namespace IdentifyTheDocument.Wrappers
{
    public interface IConsoleWrapper
    {
        void WriteLine(string value);
        void WriteLine(string format, object arg0);
    }
}