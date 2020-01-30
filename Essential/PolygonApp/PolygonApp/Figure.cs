using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
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

        public double LengthSide(Point a, Point b)
        {
            
            double length = Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
            return length;
        }

        public double CalculatePerimeter()
        {
            double perimeter = 0;

            for (int i = 1; i < _points.Length; i++)
            {
                perimeter += LengthSide(_points[i - 1], _points[i]);
            }

            perimeter += LengthSide(_points[0], _points[_points.Length - 1]);
            return perimeter;
        }

        public string GetName()
        {
            if (IsSquare())
            {
               return "square";
            }

            throw new ArgumentException("Фигура не определена");
        }

        private bool IsSquare()
        {
            return _points.Length == 4;
        }
    }
}