using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Structs p1;
            p1.X = 1;
            p1.Y = 2;

            Console.WriteLine(p1);

            Structs p2 = p1;

            p1.X = 10;

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
