using System;

namespace PolygonApp
{
    public class Figure
    {
        private Point[] _points;
        public Figure(Point[] points)
        {
            InitializeFigure(points);
        }

        public void InitializeFigure(Point[] points)
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
                perimeter += this.LengthSide(_points[i - 1], _points[i]);
            }
            perimeter += this.LengthSide(_points[0], _points[_points.Length - 1]);
            return perimeter;
        }
    }
}