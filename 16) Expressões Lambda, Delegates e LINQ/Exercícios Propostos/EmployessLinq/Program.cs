using System;
using EmployessLinq.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;

namespace EmployessLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> employees = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    employees.Add(new Employee(name, email, salary));
                }
            }

            var aboveBaseSalary = employees.Where(x => x.Salary > baseSalary).OrderBy(x => x.Name).Select(x => x.Email);
            Console.WriteLine("Email of people whose salary is more than " + baseSalary.ToString("F2", CultureInfo.InvariantCulture) + ":");
            foreach (string emails in aboveBaseSalary)
            {
                Console.WriteLine(emails);
            }

            var sumNameStartsWithM = employees.Where(x => x.Name.StartsWith('M')).Sum(x => x.Salary);
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sumNameStartsWithM.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
