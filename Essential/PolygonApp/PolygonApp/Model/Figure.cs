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

            for (var i = 1; i < _points.Length; i++)
            {
                perimeter += Distance.LengthSide(_points[i - 1], _points[i]);
            }

           return perimeter += Distance.LengthSide(_points[0], _points[_points.Length - 1]);

        }

        public  FigureType GetFigureType()
        {
            FigureType figureType = FigureType.None;

            if (IsPoint())
            {
                figureType = FigureType.Point;
            } 
            else if (IsLine())
            {
                figureType = FigureType.Line;
            }
            else if(IsTriangle())
            {
                figureType = FigureType.Triangle;
            }
            else if(IsSquare())
            {
                figureType = FigureType.Square;
            }
            else if (IsPolygon())
            {
                figureType = FigureType.Polygon;
            }
            else
            {
                throw new ArgumentException("Фигура не определена");
            }

            return figureType;

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
            if(_points.Length == 3)
            {
               return this.TriangleProperty() > 0;
            }

            return false;
        }

        private bool IsSquare()
        {
            return _points.Length == 4;
        } 
        
        private bool IsPolygon()
        {
            return _points.Length >= 5;
        }

        public double TriangleProperty()
        {
            double sum = Distance.LengthSide(_points[0], _points[1]) + Distance.LengthSide(_points[1], _points[2]); 
            return  sum -  Distance.LengthSide(_points[2], _points[0]);
        }
    }
}