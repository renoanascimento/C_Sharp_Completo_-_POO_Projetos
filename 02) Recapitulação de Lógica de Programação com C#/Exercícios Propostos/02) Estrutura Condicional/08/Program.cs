using System;
using System.Globalization;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0.0, imposto = 0.0;
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario > 0.00 && salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salario > 2000.00 && salario <= 3000.00)
            {
                imposto = (salario - 2000.00) * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario > 3000.00 && salario <= 4500.00)
            {
                imposto = 1000.00 * 0.08 + (salario - 3000.00) * 0.18;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                imposto = 1000.00 * 0.08 + 1500.00 * 0.18 + (salario - 4500.00) * 0.28;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
