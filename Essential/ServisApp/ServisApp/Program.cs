using System;

namespace ServisApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var servic = new Servic();
            servic.AddStudents("Anton", 19, 3, "Math");
            servic.AddStudents("Antony", 22, 2, "Math");
            servic.StudentAge(25);
            servic.DisplayCurs(3, "3");
            servic.DeleteByName("Anton");
            servic.DisplayAll();
        }
    }
}
