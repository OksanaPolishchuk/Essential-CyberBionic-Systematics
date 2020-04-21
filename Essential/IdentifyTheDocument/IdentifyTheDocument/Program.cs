using System;
using System.IO;
using IdentifyTheDocument.Wrappers;
using DocumentFormat.OpenXml.Drawing;
using GS;
using Newtonsoft.Json;
using OpenXmlPowerTools;
using Formatting = System.Xml.Formatting;
using Path = System.IO.Path;

namespace IdentifyTheDocument
{
    class Program
    {
        static void Main()
        {
            var path = @"C:\Work1";
            var destFiletxt = Path.Combine(path, "newTest.txt");
            var fileInfo = new FileInfoWrapper(path);
            var console = new ConsoleWrapper();
            var file = new FileWrapper();
            var directory = new DirectoryWrapper();
            var abstractHandler = new TxtHandler(file, fileInfo, console, directory);

            abstractHandler.Create(path);
            abstractHandler.Change(destFiletxt,"33");
            abstractHandler.Open(destFiletxt);

            var destFileNametxt = Path.Combine(path, @"Test.txt");
            abstractHandler.Save(destFiletxt, destFileNametxt);

            Directory.Delete(path, true);

            var pathjson = @"C:\Work3";
            var destFilejson = Path.Combine(pathjson, "tsconfig1.json");
            var fileInfojson = new FileInfoWrapper(pathjson);
            var jsonHandler = new UserHandler(file, fileInfojson, console, directory);

            jsonHandler.Create(pathjson);

            var user1 = new User();
            user1.Company = "Google";
            user1.Name = "Bob Gates";
            user1.Age = 51;
            var json = JsonConvert.SerializeObject(user1, Newtonsoft.Json.Formatting.Indented);
            var pathJson = @"jsconfig1.json";

            jsonHandler.Change(pathJson, json);

            jsonHandler.Open(destFilejson);

            var destFileNamejson = Path.Combine(pathjson, @"Json.json");
            jsonHandler.Save(pathJson, destFileNamejson);

            //Directory.Delete(pathjson, true);

            Console.ReadKey();
        }
    }
}