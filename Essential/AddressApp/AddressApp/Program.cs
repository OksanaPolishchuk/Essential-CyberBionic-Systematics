using System;
using AddressApp.Model;

namespace AddressApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();

            address.Index = " 01001";
            address.Apartment = "23";

            Console.WriteLine( "Index: " + address.Index + "\n" + "Country: " + address.Country + "\n" + "City: " + address.City + "\n" + "Street: " + address.Street + "\n" + "House: " + address.House + "\n" + "Apartment: " + address.Apartment);

            Console.ReadKey();
        }
    }
}
