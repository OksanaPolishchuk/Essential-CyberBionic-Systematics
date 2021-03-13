using System;
using System.Net.Cache;
using System.Threading;

namespace ServisApp
{
    public class Student
    {
        public string Name { get; set ; }
        public int Age { get; set; }
        public int Cours { get; set; }
        public string Specialization { get; set; }

         public Student(string name, int age, int curs, string specialization)
         {
             if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(specialization))
             {
                 throw new ArgumentNullException("empty name");
             }
            
             Age = age;
             Cours = curs;
             Specialization = specialization;
             Name = name;
         }
     }
 }
 