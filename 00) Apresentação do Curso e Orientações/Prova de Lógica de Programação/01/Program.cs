using System;
using System.Globalization;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoPecaA = 0, codigoPecaB = 0, quantidadePecaA = 0, quantidadePecaB = 0;
            double valorPecaA = 0.0, valorPecaB = 0.0, valorTotal = 0.0;

            string[] pecaA = Console.ReadLine().Split(' ');

            codigoPecaA = int.Parse(pecaA[0]);
            quantidadePecaA = int.Parse(pecaA[1]);
            valorPecaA = double.Parse(pecaA[2], CultureInfo.InvariantCulture);

            string[] pecaB = Console.ReadLine().Split(' ');

            codigoPecaB = int.Parse(pecaB[0]);
            quantidadePecaB = int.Parse(pecaB[1]);
            valorPecaB = double.Parse(pecaB[2], CultureInfo.InvariantCulture);

            valorTotal = (quantidadePecaA * valorPecaA) + (quantidadePecaB * valorPecaB);

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
