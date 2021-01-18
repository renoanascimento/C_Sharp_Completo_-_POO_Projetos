using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0, d = 0, diferenca = 0;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferenca = (a * b - c * d);

            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }
}
