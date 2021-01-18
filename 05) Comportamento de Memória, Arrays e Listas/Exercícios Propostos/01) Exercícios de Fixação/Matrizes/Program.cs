using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] estrutura = Console.ReadLine().Split(' ');
            int m = int.Parse(estrutura[0]);
            int n = int.Parse(estrutura[1]);

            int[,] matriz = new int[m, n];

            for(int i = 0; i < m; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j ] == x)
                    {
                        Console.WriteLine($"Position {i}, {j}:");

                        if (j - 1 >= 0)
                        {
                            Console.WriteLine($"Left: {matriz[i, j - 1]}");
                        }

                        if (j + 1 < n)
                        {
                            Console.WriteLine($"Right: {matriz[i, j + 1]}");
                        }

                        if (i - 1 >= 0)
                        {
                            Console.WriteLine($"Up: {matriz[i - 1, j]}");
                        }

                        if (i + 1 < n)
                        {
                            Console.WriteLine($"Down: {matriz[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}
