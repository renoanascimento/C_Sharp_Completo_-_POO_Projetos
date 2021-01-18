using System;
using System.Globalization;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int casos = 0;
            casos = int.Parse(Console.ReadLine());

            for (int i = 0; i < casos; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');
                double a = double.Parse(entradas[0], CultureInfo.InvariantCulture);
                double b = double.Parse(entradas[1], CultureInfo.InvariantCulture);
                double c = double.Parse(entradas[2], CultureInfo.InvariantCulture);

                double mediaPonderada = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
