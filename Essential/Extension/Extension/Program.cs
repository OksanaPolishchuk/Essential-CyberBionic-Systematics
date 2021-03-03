using System;
using System.Collections.Generic;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number?");
            var input = Console.ReadLine();
            
            int num = 189;
            Console.WriteLine(num.IsDividedBy(7));
            Console.WriteLine(127.IsDividedBy(5));
            
            //validation of input data
            if(int.TryParse(input, out int result))
            {
                if(result.IsEven())
                {
                    Console.WriteLine($"{result} - even number");
                }
                else
                {
                    Console.WriteLine($"{result} - odd number");
                }

                var list = new List<Road>();
            }
            else
            {
                Console.WriteLine("This is not an integer");
            }

            var roads = new List<Road>();
            for (int i = 0; i < 10; i++)
            {
                var road = new Road();
                road.CreateRandomRoad(1000, 10000);
                roads.Add(road);
            }

            var roadsName = roads.ConvToString();
            Console.WriteLine(roadsName);
            Console.ReadLine();
        }
    }
}