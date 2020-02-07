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
        public static double LengthSide(Point a, Point b)
        { 
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
    }
}
