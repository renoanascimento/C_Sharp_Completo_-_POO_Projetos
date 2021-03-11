using System;

namespace ExtensionDate
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 03, 11, 08, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear students!";

            Console.WriteLine(s1.Cut(10));
        }
    }
}
