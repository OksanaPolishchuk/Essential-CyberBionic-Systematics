using System;

namespace CompanyApp
{
    public class Workman : IWorkman
    {
        public string FullName { get; set; }
        public int Experience { get; set; }
        public Workman(string fullName, int experience)
        {
            FullName = fullName;
            Experience = experience;
        }
        
        public void Work()
        {
            Console.WriteLine("Produces the products");
        }
    }
}
