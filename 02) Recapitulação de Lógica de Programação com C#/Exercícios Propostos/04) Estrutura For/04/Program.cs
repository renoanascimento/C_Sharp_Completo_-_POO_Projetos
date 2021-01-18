using System;
using System.Globalization;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int casos = 0;
            casos = int.Parse(Console.ReadLine());

            for (int i = 0; i < casos; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int a = int.Parse(valores[0]);
                int b = int.Parse(valores[1]);

                if (b == 0)
                {
                    Console.WriteLine("divisão impossível");
                }
                else
                {
                    double resultadoDivisao = (double)a / b;
                    Console.WriteLine(resultadoDivisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
