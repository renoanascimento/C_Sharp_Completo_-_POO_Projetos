using System;
using System.Globalization;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, horasTrabalhadas = 0;
            double valorHora = 0.0, salario = 0.0;

            numero = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horasTrabalhadas * valorHora;

            Console.WriteLine($"NUMBER = {numero}");
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
