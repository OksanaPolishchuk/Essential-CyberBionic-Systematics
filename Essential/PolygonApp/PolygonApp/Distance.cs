using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolygonApp.Model;

namespace PolygonApp
{
    public class Distance
    {
        private readonly Point[] _points;
        private double _length;

        public Distance(Point[] points)
        {
            _points = points;
        }

        public double Length
        {
            get { return _length; }
            set { _length = value; }
        }
    
        public double LengthSide(Point a, Point b)
        { 
            return Length = Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
    }
}
