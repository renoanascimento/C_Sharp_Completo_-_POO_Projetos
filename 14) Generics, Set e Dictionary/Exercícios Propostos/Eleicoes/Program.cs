using System;
using System.IO;
using System.Collections.Generic;
using Eleicoes.Entities;

namespace Eleicoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o caminho do arquivo: ");
            string caminho = Console.ReadLine();

            Dictionary<Candidatos, int> votos = new Dictionary<Candidatos, int>();

            try
            {
                using (StreamReader sr = File.OpenText(caminho))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] linha = sr.ReadLine().Split(',');
                        string nome = linha[0];
                        int quantidadeVotos = int.Parse(linha[1]);
                        Candidatos candidato = new Candidatos() { Nome = nome };
                        if (!votos.ContainsKey(candidato))
                        {
                            votos.Add(candidato, quantidadeVotos);
                        }
                        else
                        {
                            votos[candidato] = votos[candidato] + quantidadeVotos;
                        }
                    }
                }

                foreach (var item in votos)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
