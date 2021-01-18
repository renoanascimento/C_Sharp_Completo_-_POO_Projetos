using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            string quadrante;

            string[] coordenadas = Console.ReadLine().Split(' ');
            x = int.Parse(coordenadas[0]);
            y = int.Parse(coordenadas[1]);

            while (x != 0 && y != 0)
            {
                quadrante = Quadrante(x, y);
                Console.WriteLine(quadrante);

                coordenadas = Console.ReadLine().Split(' ');
                x = int.Parse(coordenadas[0]);
                y = int.Parse(coordenadas[1]);
            }
        }

        static string Quadrante (int x, int y)
        {
            string quadrante = null;

            if (x > 0 && y > 0)
            {
               quadrante = "primeiro";
            }
            else if (x > 0 && y < 0)
            {
                quadrante = "quarto";
            }
            else if (y < 0)
            {
                quadrante = "terceiro";
            }
            else
            {
                quadrante = "segundo";
            }

            return quadrante;
        }
    }
}
