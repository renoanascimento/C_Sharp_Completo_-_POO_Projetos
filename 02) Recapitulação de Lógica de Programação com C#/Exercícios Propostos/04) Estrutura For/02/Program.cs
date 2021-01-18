using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = 0, contEntreDezEVinte = 0;
            quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                int valor = int.Parse(Console.ReadLine());

                if (valor >= 10 && valor <= 20)
                {
                    contEntreDezEVinte++;
                }
            }

            Console.WriteLine(contEntreDezEVinte + " in");
            Console.WriteLine(quantidade - contEntreDezEVinte + " out");
        }
    }
}
