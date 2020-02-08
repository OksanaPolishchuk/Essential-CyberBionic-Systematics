using System;
using PolygonApp.Service;

namespace PolygonApp.Model
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
            if (IsPoint())
            {
                return "point";
            }

            if (IsLine())
            {
                return "line";
            }

            if (IsTriangle())
            {
                return "triangle";
            }

            if (IsSquare())
            {
                return "square";
            }
            
            if (IsPolygon())
            {
                return "polygon";
            }

            throw new ArgumentException("Фигура не определена");
        }

        private bool IsPolygon()
        {
            return _points.Length >= 5;
        }

        private bool IsSquare()
        {
            return _points.Length == 4;
        }

        private bool IsTriangle()
        {
            return _points.Length == 3;
        }

        private bool IsLine()
        {
            return _points.Length == 2;
        }

        private bool IsPoint()
        {
            return _points.Length == 1;
        }
    }
}