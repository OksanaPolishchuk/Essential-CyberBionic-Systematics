using System;
using AddressApp.Model;

namespace AddressApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address(index: "01001", country: "Ukraine", city: "Kiev", street: "Kreschatik", house: "1/1", apartment: "23");

            Console.WriteLine(address);

            Console.ReadKey();
        }
    }
}
