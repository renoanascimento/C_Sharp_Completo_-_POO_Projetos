using System;
using System.Collections.Generic;
using TotalStudents.Entities;

namespace TotalStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> students = new HashSet<Student>();
            int courses = 0;

            while (courses < 3)
            {
                if (courses == 0)
                {
                    Console.Write("How many students for course A? ");
                }
                else if (courses == 1)
                {
                    Console.Write("How many students for course B? ");
                }
                else
                {
                    Console.Write("How many students for course C? ");
                }
                
                int quantity = int.Parse(Console.ReadLine());

                for (int i = 0; i < quantity; i++)
                {
                    int matricula = int.Parse(Console.ReadLine());
                    Student student = new Student() { Matricula = matricula };
                    students.Add(student);
                }

                courses++;
            }

            Console.WriteLine("Total students: " + students.Count);
        }
    }
}
