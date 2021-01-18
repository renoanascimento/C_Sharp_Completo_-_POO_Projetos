using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 0;
            senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Inválida");

                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
