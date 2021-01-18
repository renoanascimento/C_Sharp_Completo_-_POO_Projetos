using System;
using System.Globalization;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0.0f, b = 0.0f, c = 0.0f,
                  areaTriangulo = 0.0f, areaCirculoRaio = 0.0f, areaTrapezio = 0.0f, 
                  areaQuadrado = 0.0f, areaRetangulo = 0.0f, pi = 3.14159f;
            string[] entradas;

            entradas = Console.ReadLine().Split(' ');

            a = float.Parse(entradas[0], CultureInfo.InvariantCulture);
            b = float.Parse(entradas[1], CultureInfo.InvariantCulture);
            c = float.Parse(entradas[2], CultureInfo.InvariantCulture);

            areaTriangulo = (a * c) / 2.0f;
            areaCirculoRaio = pi * (c * c);
            areaTrapezio = ((a + b) / 2.0f) * c;
            areaQuadrado = b * b;
            areaRetangulo = a * b;

            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CÍRCULO: " + areaCirculoRaio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
