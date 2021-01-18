using System;
using System.Globalization;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoItem = 0, quantidadeItem = 0;
            double valorTotal = 0.0;

            string[] entradas = Console.ReadLine().Split(' ');
            codigoItem = int.Parse(entradas[0]);
            quantidadeItem = int.Parse(entradas[1]);

            switch (codigoItem)
            {
                case 1:
                    valorTotal = quantidadeItem * 4.00;
                    break;
                case 2:
                    valorTotal = quantidadeItem * 4.50;
                    break;
                case 3:
                    valorTotal = quantidadeItem * 5.00;
                    break;
                case 4:
                    valorTotal = quantidadeItem * 2.00;
                    break;
                case 5:
                    valorTotal = quantidadeItem * 1.50;
                    break;
            }

            Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
