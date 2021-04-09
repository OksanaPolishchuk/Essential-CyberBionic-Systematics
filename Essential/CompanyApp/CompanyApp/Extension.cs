using System;
using System.Linq;

namespace CompanyApp
{
    public static class Extension
    {
        public static bool ContainsEmployee(this Firm firm, IEmployee employee)
        {
            return firm.Employees.Any(employees => employees.Equals(employee));
        }

        public static void OutputEmployees(this Firm firm)
        {
            Console.WriteLine("\nList of employees:");
            foreach (var employee in firm.Employees)
            {
                Console.WriteLine($"\nFullName: {employee.FullName} \nExperience: {employee.Experience}.");
            }
        }
    }
}
