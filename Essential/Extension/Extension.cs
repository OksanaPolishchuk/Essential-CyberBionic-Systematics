using System;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number?");
            var input = Console.ReadLine();
            
            int num = 189;
            Console.WriteLine(num.isDividedBy(7));
            Console.WriteLine(127.isDividedBy(5));
            
            //validation of input data
            if(int.TryParse(input, out int result))
            {
                //var isEven = IsEven(result);
                //result.IsEven();
                if(result.IsEven())
                {
                    Console.WriteLine($"{result} - even number");
                }
                else
                {
                    Console.WriteLine($"{result} - odd number");
                }
            }
            else
            {
                Console.WriteLine("This is not an integer");
            }
            
            Console.ReadKey();
        }
    }
}
