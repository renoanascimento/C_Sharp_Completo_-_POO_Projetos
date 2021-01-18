using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Employee #{i + 1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                employees.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());

            Employee employeeIncrease = employees.Find(x => x.Id == idIncrease);

            if (employeeIncrease != null)
            {
                Console.Write("Enter the percentage: ");
                double percentageIncrease = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employeeIncrease.IncreaseSalary(percentageIncrease);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("This id does not exist!");
                Console.WriteLine();
            }

            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in employees)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
