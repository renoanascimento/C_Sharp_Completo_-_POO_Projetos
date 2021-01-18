using System;

namespace VetoresObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Students[] students = new Students[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Rent #{i + 1}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();

                //instanciação automática
                students[room] = new Students { Name = name, Email = email };

            }

            Console.WriteLine("Busy rooms:");

            for (int i = 0; i < 10; i++)
            {
                if(students[i] != null)
                {
                    Console.WriteLine(i + ": " + students[i]);
                }
            }
        }
    }
}
