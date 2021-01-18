using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
