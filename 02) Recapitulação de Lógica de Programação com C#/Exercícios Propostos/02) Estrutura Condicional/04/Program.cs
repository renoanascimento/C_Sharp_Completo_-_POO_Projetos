using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial = 0, horaFinal = 0, duracao = 0;

            string[] entradas = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(entradas[0]);
            horaFinal = int.Parse(entradas[1]);

            if (horaFinal > horaInicial)
            {
                duracao = horaFinal - horaInicial;
            }
            else if (horaInicial == horaFinal)
            {
                duracao = 24;
            }
            else
            {
                duracao = 24 - (horaInicial - horaFinal);
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");

        }
    }
}
