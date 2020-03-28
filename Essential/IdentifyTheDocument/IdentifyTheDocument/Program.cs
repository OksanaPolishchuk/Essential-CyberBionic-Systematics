using System;
using System.IO;
using IdentifyTheDocument.Wrappers;

namespace IdentifyTheDocument
{
    class Program
    {
        static void Main()
        {
            var path = @"C:\Work1";
            var destFile = Path.Combine( path, @"newTest.txt");
            var fileInfo = new FileInfoWrapper(path);
            var console = new ConsoleWrapper();
            var file = new FileWrapper();
            var directory = new DirectoryWrapper();

            var abstractHandler = new AbstractHandler(file, fileInfo, console,directory);
            //abstractHandler.Change("");

            abstractHandler.Create(path);

            abstractHandler.Change( destFile,"33");
            abstractHandler.Open(destFile);

            var destFileName = Path.Combine(path, @"Test.txt");
            abstractHandler.Save(destFile, destFileName);

            Directory.Delete(path, true);

            Console.ReadKey();
        }
    }
}