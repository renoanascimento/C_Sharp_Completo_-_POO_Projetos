using System;
using System.Globalization;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = 0.0, area = 0.0;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
