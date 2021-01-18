using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            
            Console.Write("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nomeDoTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char opcaoDepositoInicial = char.Parse(Console.ReadLine());

            if (opcaoDepositoInicial == 's')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double valorDepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numeroConta, nomeDoTitular, valorDepositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numeroConta, nomeDoTitular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(valorDeposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(valorSaque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
            Console.WriteLine();
        }
    }
}
