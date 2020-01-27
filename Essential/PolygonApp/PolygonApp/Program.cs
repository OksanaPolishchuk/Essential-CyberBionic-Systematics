using System;

namespace PolygonApp
{
    class Program
    {
        static void Main(string[]args)
        {
            Point point = new Point("");

            Options options = new Options();
            
            Console.WriteLine($"\nPerimeter:  {options.Perimeter}\n"+
                              $"\n Name of the figure: {point.Name}");

            Console.ReadKey();
        }

    }
}

