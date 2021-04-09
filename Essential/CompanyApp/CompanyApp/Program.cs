using System;

namespace CompanyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var firm = new Firm();
            
            var manager = new Manager("Pete Savchenko", 18);
            var secondmanager = new Manager("Oksana Polishchuk", 14);
            var workMan = new Workman("Natasha Sov", 5);
            var brigadier = new Brigadier("Tod Popov", 7);
            
            Console.WriteLine($"\nNew employees were added to the base: {firm + manager}", $"{firm + secondmanager}",
                $"{firm + workMan}", $"{firm + brigadier}");
            
            var numberOfEmployees = firm.WorkersCounter<IEmployee>();
            Console.WriteLine($"\nNumber of employees: {numberOfEmployees}");
            
            var getBrigadier = firm.WorkersCounter<Brigadier>();
            Console.WriteLine($"\nNumber of brigadiers: {getBrigadier}");
            
            firm.OutputEmployees();
            
            Console.ReadKey();
        }
    }
}
