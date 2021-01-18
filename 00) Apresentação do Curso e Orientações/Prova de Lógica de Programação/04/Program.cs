using System;
using System.Globalization;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.0, b = 0.0, c = 0.0, x1 = 0.0, x2 = 0.0, delta = 0.0;

            string[] entradas = Console.ReadLine().Split(' ');
            a = double.Parse(entradas[0], CultureInfo.InvariantCulture);
            b = double.Parse(entradas[1], CultureInfo.InvariantCulture);
            c = double.Parse(entradas[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2) - (4.0 * a * c);

            if (a == 0.0 || delta < 0)
            {
                Console.WriteLine("Impossível calcular");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine("X1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}
