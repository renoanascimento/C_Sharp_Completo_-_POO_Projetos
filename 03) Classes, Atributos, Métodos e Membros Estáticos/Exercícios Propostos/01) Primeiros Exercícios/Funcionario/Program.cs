using System;
using System.Globalization;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionarioA, funcionarioB;
            double salarioMedio = 0.0;
            funcionarioA = new Funcionario();
            funcionarioB = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário");
            Console.Write("Nome: ");
            funcionarioA.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionarioA.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário");
            Console.Write("Nome: ");
            funcionarioB.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionarioB.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioMedio = (funcionarioA.Salario + funcionarioB.Salario) / 2.0;

            Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
