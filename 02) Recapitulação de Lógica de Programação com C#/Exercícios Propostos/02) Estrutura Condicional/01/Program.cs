using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            x = int.Parse(Console.ReadLine());

            if (x < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
        }
    }
}
