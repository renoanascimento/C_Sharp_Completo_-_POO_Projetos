using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, aux = 0;

            string[] entradas = Console.ReadLine().Split(' ');

            a = int.Parse(entradas[0]);
            b = int.Parse(entradas[1]);

            if (b > a)
            {
                aux = a;
                a = b;
                b = aux;
            }

            if (a % b == 0)
            {
                Console.WriteLine("São Múltiplos");
            }
            else
            {
                Console.WriteLine("Não São Múltiplos");
            }
        }
    }
}
