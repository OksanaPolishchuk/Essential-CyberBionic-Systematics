using System;

namespace CompanyApp
{
    public class Manager : IManager
    {
        public string FullName { get; set; }
        public int Experience { get; set; }
        public Manager(string fullName, int experience)
        {
            FullName = fullName;
            Experience = experience;
        }
        
        public void Work()
        {
            Console.WriteLine("Forms the orders.");
        }

        public void GiveTask()
        {
            Console.WriteLine("The task was issued");
        }
    }
}
