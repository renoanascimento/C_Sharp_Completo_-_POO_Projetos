using System;
using System.IO;

namespace FileStream_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Renoá\Udemy\C# Completo -  POO + Projetos\12) Trabalhando com Arquivos\Aulas\Aula 187 - FileStream e StreamReader\File1.txt";
            //FileStream fs = null;
            StreamReader sr = null;
            try
            {
                //fs = new FileStream(path, FileMode.Open);
                // Nesse caso usando diretamente a classe file não é necessário a criação do objeto do tipo FileStream, nem seu fechamento, pois
                // indiretamente o método File.OpenText entende que precisará ler o arquivo e implicitamente "cria" um objeto
                // do tipo FileStream.
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                //if (fs != null)
                //{
                //    fs.Close();
                //}
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
