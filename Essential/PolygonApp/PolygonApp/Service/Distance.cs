using System;
using PolygonApp.Model;

namespace PolygonApp.Service
{
    public class Distance
    {
        public static double LengthSide(Point a, Point b)
        { 
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
    }
}