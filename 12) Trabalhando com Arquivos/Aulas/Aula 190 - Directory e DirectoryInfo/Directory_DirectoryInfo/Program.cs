using System;
using System.IO;

namespace Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Renoá\Udemy\C# Completo -  POO + Projetos\12) Trabalhando com Arquivos\Aulas\Aula 190 - Directory e DirectoryInfo\Teste";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "\\NewFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
