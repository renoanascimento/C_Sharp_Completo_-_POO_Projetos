using System;
using System.IO;
using System.Globalization;
using ReadWriteSystem.Entities;
using System.Collections.Generic;

namespace ReadWriteSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the full path of input file:");
            string sourcePath = Console.ReadLine();
            List<Product> products = new List<Product>();

            try
            {
                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] datas = line.Split(',');

                        string name = datas[0];
                        double price = double.Parse(datas[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(datas[2]);

                        Product product = new Product(name, price, quantity);
                        products.Add(product);
                    }
                }

                string directory = Path.GetDirectoryName(sourcePath);
                Directory.CreateDirectory(directory + @"\out");
                string targetPath = directory + @"\out\Summary.csv";

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (Product p in products)
                    {
                        sw.WriteLine(p.ToString());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occcured!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
