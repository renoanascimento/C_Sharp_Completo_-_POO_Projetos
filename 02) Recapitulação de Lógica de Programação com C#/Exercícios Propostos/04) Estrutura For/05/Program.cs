using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, fatorial = 1;
            n = int.Parse(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine(fatorial);
        }
    }
}
