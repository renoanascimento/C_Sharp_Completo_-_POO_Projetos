using System;
using System.IO;

namespace Stream_Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\Renoá\Udemy\C# Completo -  POO + Projetos\12) Trabalhando com Arquivos\Aulas\Aula 189 - StreamWriter\File1.txt";
            string targetPath = @"D:\Renoá\Udemy\C# Completo -  POO + Projetos\12) Trabalhando com Arquivos\Aulas\Aula 189 - StreamWriter\File2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using(StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
