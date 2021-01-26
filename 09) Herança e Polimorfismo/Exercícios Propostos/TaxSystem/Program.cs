﻿using System;
using System.Collections.Generic;
using TaxSystem.Entities;
using System.Globalization;

namespace TaxSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalTax = 0.0;
            
            Console.Write("Enter the number of tax payers: ");
            int quantity = int.Parse(Console.ReadLine());

            List<TaxPayer> taxPayers = new List<TaxPayer>();

            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberofEmployees = int.Parse(Console.ReadLine());

                    taxPayers.Add(new Company(name, anualIncome, numberofEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            foreach(TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine(taxPayer.Name + ": $ " + taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                totalTax += taxPayer.Tax();
            }

            Console.WriteLine();
            Console.Write("TOTAL TAXES: $ " + totalTax.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
