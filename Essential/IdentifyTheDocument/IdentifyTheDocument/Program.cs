using System;

namespace IdentifyTheDocument
{
    class Program
    {
        static void Main()
        {
            var path = @"C:\Work2\Test.txt";
            var fileInfo = new FileInfoWrapper(path);
            var a = new AbstractHandler(fileInfo);
            a.Open();

            Console.ReadKey();
        }
    }
}