using System;

namespace PolygonApp
{
    public class Point
    {
        private int _x ,_y;
        private string _name;

        public Point(string name)
        {
            Console.WriteLine("\n What is the name of the figure?");
           name = _name = Console.ReadLine();
        }

        public Point(int x, int y)
        { 
            _x = x;
            _y = y;
        }
        public int X
        {
            get { return _x; }
        }

        public int Y
        {
            get { return _y; }
        }
        public string Name
        {
            get { return _name; }
        }
    }
}