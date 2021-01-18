using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, entreDezEVinte = 0;
            int[] valores;

            n = int.Parse(Console.ReadLine());
            valores = new int[n];

            for (int i = 0; i < n; i++)
            {
                valores[i] = int.Parse(Console.ReadLine());

                if (valores[i] >= 10 && valores[i] <= 20)
                {
                    entreDezEVinte++;
                }
            }

            Console.WriteLine(entreDezEVinte + " in");
            Console.WriteLine(n - entreDezEVinte + " out");
        }
    }
}
