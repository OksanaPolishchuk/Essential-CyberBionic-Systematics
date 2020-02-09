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

        public FigureType GetName()
        {
            if (IsPoint())
            {
                FigureType figureType = FigureType.Point;

                return figureType;
            }

            if (IsLine())
            {
                FigureType figureType = FigureType.Line;

                return figureType;
            }

            if (IsTriangle())
            {
                FigureType figureType = FigureType.Triangle;

                return figureType;
            }

            if (IsSquare())
            {
                FigureType figureType = FigureType.Square;

                return figureType;
            }

            if (IsPolygon())
            {
                FigureType figureType = FigureType.Polygon;

                return figureType;
            }

            throw new ArgumentException("Фигура не определена");
        }

        public enum FigureType
        {
            None = 0,
            Point = 1,
            Line = 2,
            Triangle = 3,
            Square = 4,
            Polygon = 5
        }
       
        private bool IsPoint()
        {
            return _points.Length == 1;
        }

        private bool IsLine()
        {
            return _points.Length == 2;
        }

        private bool IsTriangle()
        {
            return _points.Length == 3;
        }

        private bool IsSquare()
        {
            return _points.Length == 4;
        } 
        
        private bool IsPolygon()
        {
            return _points.Length >= 5;
        }
    }
}