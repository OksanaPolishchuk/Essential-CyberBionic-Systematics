using System;
using IdentifyTheDocument.Wrappers;

namespace IdentifyTheDocument
{
    class Program
    {
        static void Main()
        {
            var path = @"C:\Work2\Test.txt";
            var fileInfo = new FileInfoWrapper(path);
            var console = new ConsoleWrapper();
            var file = new FileWrapper();

            var abstractHandler = new AbstractHandler(file, fileInfo, console);
            abstractHandler.Open();
            abstractHandler.Change("33");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}