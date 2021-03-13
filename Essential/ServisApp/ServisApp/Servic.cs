using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;

namespace ServisApp
{
    public class Servic
    {
        private List<Student> _students = new List<Student>();
        public void AddStudents(string name, int age, int cours, string specialization)
        {
            _students.Add(new Student(name, age,cours, specialization));
        }
        
        public void DisplayAll()
        {
            foreach (var i in _students)
            {
                Console.WriteLine($"{i.Name} - {i.Age} - {i.Cours} - {i.Specialization}");
            }
        }

        public void StudentAge(int age)
        {
            var studentAge = _students.Where(agetudent => agetudent.Age > age);
            foreach (var ages in studentAge)
            {
                Console.WriteLine(ages.Age);
            }
        }

        public void DisplayCurs(int curs, string specialization)
        {
            var studentCurs = _students.Where(curstudent => curstudent.Cours == 3 && curstudent.Specialization == specialization);
            foreach (var curses in studentCurs)
            {
                Console.WriteLine($"{curses.Name} {curses.Cours} {curses.Specialization}");
            }
        }

        public void DeleteByName(string nema)
        {
            var studentName = _students.Where(nametudent => nametudent.Name == nema).Select(x => x).First();
            _students.Remove(studentName);
        }
    }
}
