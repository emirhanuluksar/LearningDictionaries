using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> NewStudents = new List<Student>()
            {
                new Student{No=100,Name="John",Surname="Doe"},
                new Student{No=110,Name="John2",Surname="Doe"},
                new Student{No=130,Name="John3",Surname="Doe"}
            };

            Dictionary<Double, Student> List = NewStudents.ToDictionary(N => N.No);
            foreach (var student in NewStudents)
            {
                Console.WriteLine(student.No.ToString() + "-" + student.Name + " " + student.Surname);
            }
        }
    }

    class Student
    {
        public double No { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
