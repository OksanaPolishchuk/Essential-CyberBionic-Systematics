using System;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            Rectangle rectangle1 = new Rectangle();

            int side1, side2;
            Console.WriteLine(" Enter first side:");
            Int32.TryParse(Console.ReadLine(), out side1);
            Console.WriteLine(" Enter second side:");
            Int32.TryParse(Console.ReadLine(), out side2);


            Console.WriteLine("\n" + new string('-', 30));

            Rectangle rectangle2 = new Rectangle(side1, side2);
            Console.WriteLine("Area: " + rectangle2.Area + "\nPerimeter: " + rectangle2.Perimeter);

            Console.ReadKey();
        }
    }
}