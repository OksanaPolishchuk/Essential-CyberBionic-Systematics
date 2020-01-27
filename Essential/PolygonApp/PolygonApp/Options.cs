using System;
using PolygonApp.Model;

namespace PolygonApp
{
    class Options
    {
        private double _perimeter;

        public double Perimeter
        {
            get
            {
                return _perimeter;
            }
            set
            {
                _perimeter = value;
            }
        }

        public Options()
        {
            Console.WriteLine("\n How many sides?");
            int numberOfSides = int.Parse(Console.ReadLine());
            Point[] points = new Point[numberOfSides];

            Console.WriteLine("\n Enter coordinates in format x1 y1 x2 y2 x3 y3: ");
            string input = Console.ReadLine();
            //1 1 3 3 7 7 

            int[] coordinates = new int[numberOfSides * 2];  //{1, 1, 3, 3, 7, 7} 
            string tempString = "";
            int coordinatesIndex = 0;

            for (int i = 0; i < input.Length; ++i)
            {
                if (input[i] != ' ')
                {
                    tempString += input[i];
                }
                else
                {
                    coordinates[coordinatesIndex] = int.Parse(tempString);
                    ++coordinatesIndex;
                    tempString = "";
                }
            }

            if (tempString != "")
            {
                coordinates[coordinatesIndex] = int.Parse(tempString);
            }

            for (int i = 0; i < numberOfSides; ++i)
            {

                points[i] = new Point(coordinates[i * 2], coordinates[i * 2 + 1], "");
            }
            
            Figure polygon = new Figure(points);
            this._perimeter = polygon.CalculatePerimeter();

        }
    }
}
