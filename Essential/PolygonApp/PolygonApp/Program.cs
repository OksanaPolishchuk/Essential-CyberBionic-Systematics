using System;
using PolygonApp.Model;

namespace PolygonApp
{
    class Program
    {
        static void Main()
        {
            var pointA = new Point(x: 1, y: 2, name: "A");
            var pointB = new Point(x: 2, y: 3, name: "B");

            Figure coordinates = new Figure(points: new Point[] {pointA,pointB});
           
            

            Console.WriteLine($"{coordinates.CalculatePerimeter()},");

            Console.ReadKey();
        }
    }
}