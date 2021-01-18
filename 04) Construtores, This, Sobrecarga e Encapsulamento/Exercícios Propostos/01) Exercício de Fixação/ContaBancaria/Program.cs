using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroConta = 0;
            string nomeDoTitular = null;
            char opcaoDepositoInicial = ' ';
            double valorDeposito = 0.0, valorSaque = 0.0;
            
            Console.Write("Entre com o número da conta: ");
            numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            nomeDoTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            opcaoDepositoInicial = char.Parse(Console.ReadLine());

            if (opcaoDepositoInicial == 's')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Conta conta = new Conta(numeroConta, nomeDoTitular, valorDeposito);

            Console.WriteLine();
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(valorDeposito);
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(valorSaque);
            Console.WriteLine(conta);
            Console.WriteLine();
        }
    }
}
