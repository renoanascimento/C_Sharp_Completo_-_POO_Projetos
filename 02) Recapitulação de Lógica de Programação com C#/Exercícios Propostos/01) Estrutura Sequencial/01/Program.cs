using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, soma = 0;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            soma = x + y;

            Console.WriteLine($"SOMA = {soma}");
        }
    }
}
