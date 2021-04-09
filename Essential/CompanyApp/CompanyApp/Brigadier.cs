using System;

namespace CompanyApp
{
    public class Brigadier : IBrigadier
    { 
        public string FullName { get; set; }
        public int Experience { get; set; }
        public Brigadier(string fullName, int experience)
        {
            FullName = fullName;
            Experience = experience;
        }
        
        public void Work()
        {
            Console.WriteLine("Placed an order for materials");
        }

        public void EmployeesControl()
        {
            Console.WriteLine("Employees verification");
        }
    }
}
