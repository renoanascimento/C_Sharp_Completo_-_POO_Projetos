using System;
using System.IO;

namespace File_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\Renoá\Udemy\C# Completo -  POO + Projetos\12) Trabalhando com Arquivos\Aulas\Aula 186 - File e FileInfo\File1.txt";
            string targetPath = @"D:\Renoá\Udemy\C# Completo -  POO + Projetos\12) Trabalhando com Arquivos\Aulas\Aula 186 - File e FileInfo\File2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
