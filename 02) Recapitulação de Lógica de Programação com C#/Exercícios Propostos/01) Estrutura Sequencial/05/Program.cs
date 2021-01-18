using System;
using System.Globalization;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoPeca1 = 0, codigoPeca2 = 0, quantidadePeca1 = 0, quantidadePeca2 = 0;
            double valorPeca1 = 0.0, valorPeca2 = 0.0, valorTotal = 0.0;
            string[] entradas;

            entradas = Console.ReadLine().Split(' ');

            codigoPeca1 = int.Parse(entradas[0]);
            quantidadePeca1 = int.Parse(entradas[1]);
            valorPeca1 = double.Parse(entradas[2], CultureInfo.InvariantCulture);

            entradas = Console.ReadLine().Split(' ');

            codigoPeca2 = int.Parse(entradas[0]);
            quantidadePeca2 = int.Parse(entradas[1]);
            valorPeca2 = double.Parse(entradas[2], CultureInfo.InvariantCulture);

            valorTotal = quantidadePeca1 * valorPeca1 + quantidadePeca2 * valorPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
