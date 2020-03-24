using System;

namespace IdentifyTheDocument.Wrappers
{
    class ConsoleWrapper : IConsoleWrapper
    {
        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }

        public void WriteLine(string format, object arg0)
        {
            Console.WriteLine(format, arg0);
        }
    }
}