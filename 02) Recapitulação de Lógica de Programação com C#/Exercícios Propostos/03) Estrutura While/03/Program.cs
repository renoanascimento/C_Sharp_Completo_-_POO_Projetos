using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo = 0, contAlcool = 0, contGasolina = 0, contDiesel = 0;
            codigo = int.Parse(Console.ReadLine());

            

            while (codigo < 1 || codigo > 4)
            {
                if (codigo == 4)
                {
                    break;
                }

                codigo = int.Parse(Console.ReadLine());

                while (codigo >= 1 && codigo <= 3)
                {
                    if (codigo == 1)
                    {
                        contAlcool++;
                    }
                    else if (codigo == 2)
                    {
                        contGasolina++;
                    }
                    else
                    {
                        contDiesel++;
                    }

                    codigo = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {contAlcool}");
            Console.WriteLine($"Gasolina: {contGasolina}");
            Console.WriteLine($"Diesel: {contDiesel}");
        }
    }
}
