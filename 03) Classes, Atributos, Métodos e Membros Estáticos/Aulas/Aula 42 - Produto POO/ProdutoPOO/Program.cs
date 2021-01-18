using System;
using System.Globalization;

namespace ProdutoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            int quantidade = 0;
            
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(produto);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(quantidade);

            Console.WriteLine();
            Console.WriteLine(produto);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(quantidade);

            Console.WriteLine();
            Console.WriteLine(produto);
        }
    }
}
