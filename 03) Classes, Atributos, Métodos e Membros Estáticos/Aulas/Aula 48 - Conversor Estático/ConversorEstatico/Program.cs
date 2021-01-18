using System;
using System.Globalization;

namespace ConversorEstatico
{
    class Program
    {
        static void Main(string[] args)
        {
            double CotacaoDolar = 0.0, ValorASerComprado = 0.0, valorASerPago = 0.0;

            Console.Write("Qual é a cotação do dólar? ");
            CotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            ValorASerComprado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valorASerPago = ConversorDeMoeda.ConversorComIOF(CotacaoDolar, ValorASerComprado);

            Console.WriteLine("Valor a ser pago em reais = " + valorASerPago.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
