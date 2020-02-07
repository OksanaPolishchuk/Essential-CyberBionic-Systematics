using System;
using System.Runtime.InteropServices.ComTypes;
using PolygonApp.Model;

namespace PolygonApp
{
    public class Figure
    {
        private readonly Point[] _points;
        public Figure(Point[] points)
        {
            _points = points;
        }
        
        public double CalculatePerimeter()
        {
            double perimeter = 0;

            for (int i = 1; i < _points.Length; i++)
            {
                perimeter += Distance.LengthSide(_points[i - 1], _points[i]);
            }

            perimeter += Distance.LengthSide(_points[0], _points[_points.Length - 1]);
            return perimeter;
        }

        public string GetName()
        {
            if (IsSquare())
            {
                return "square";
            }

            if (IsTriangle())
            {
                return "triangle";
            }

            if (IsDistance())
            {
                return "distance between two points";
            }
          
            throw new ArgumentException("Фигура не определена");
        }

        private bool IsSquare()
        {
            return _points.Length == 4;
        }

        private bool IsTriangle()
        {
            return _points.Length == 3;
        }

        private bool IsDistance()
        {
            return _points.Length == 2;
        }
    }
}