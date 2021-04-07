using System;

namespace SalonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Administrator administrator = new Administrator();
            
            Salon salon = new Salon("Lab360", administrator);
            Client client = new Client("Katya Polishchuk", administrator); 
            
            administrator.Services();
            client.StopTrade();

            Console.Read();
        }
    }
}