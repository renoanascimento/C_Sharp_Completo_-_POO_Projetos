using System;
using System.Globalization;

namespace _03SistemaDeNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.NomeAluno = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.NotaPrimeiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaSegundoTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaTerceiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(aluno.Resultado());
        }
    }
}
