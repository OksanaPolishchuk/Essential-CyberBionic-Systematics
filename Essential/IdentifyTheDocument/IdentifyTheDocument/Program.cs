using System;
using System.IO;
using IdentifyTheDocument.Wrappers;

namespace IdentifyTheDocument
{
    class Program
    {
        static void Main()
        {
            var path = @"C:\Work\newTest.txt";
            var fileInfo = new FileInfoWrapper(path);
            var console = new ConsoleWrapper();
            var file = new FileWrapper();
            var directory = new DirectoryWrapper();

            var abstractHandler = new AbstractHandler(file, fileInfo, console,directory);
            //abstractHandler.Change("");

            var destDirName = @"C:\Work1";
            abstractHandler.Create(destDirName);
            
            abstractHandler.Open();
            abstractHandler.Change("33");

            var destFileName = Path.Combine(destDirName, @"Test.txt");
            abstractHandler.Save(path, destFileName);

            Directory.Delete(destDirName, true);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}