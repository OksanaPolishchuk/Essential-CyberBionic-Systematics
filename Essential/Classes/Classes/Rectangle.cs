using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Rectangle
    {
        private double side1 = 5, side2 = 2;

        public double Side1
        {
            get { return side1; }
        }

        public double Side2
        {
            get { return side2; }

        }

        public Rectangle()
        {
            Console.WriteLine("По умолчанию");
        }

        public Rectangle(int side1_, int side2_)
        {
            this.side1 = side1_;
            this.side2 = side2_;
        }
        private double AreaCalculator()
        {
            return this.side1 * this.side2;
        }
        private double PerimeterCalculator()
        {
            return 2 * (this.side1 + this.side2);
        }
        public double Area
        {
            get { return AreaCalculator(); }
        }
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    }
}