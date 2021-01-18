using System;
using System.Globalization;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoItem = 0, quantidadeItem = 0;
            double valorConta = 0.0;

            string[] entradas = Console.ReadLine().Split(' ');

            codigoItem = int.Parse(entradas[0]);
            quantidadeItem = int.Parse(entradas[1]);

            if (codigoItem == 1)
            {
                valorConta = quantidadeItem * 4.00;
            }
            else if (codigoItem == 2)
            {
                valorConta = quantidadeItem * 4.50;
            }
            else if (codigoItem == 3)
            {
                valorConta = quantidadeItem * 5.00;
            }
            else if (codigoItem == 4)
            {
                valorConta = quantidadeItem * 2.00;
            }
            else
            {
                valorConta = quantidadeItem * 1.50;
            }

            Console.WriteLine("Total: R$ " + valorConta.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
