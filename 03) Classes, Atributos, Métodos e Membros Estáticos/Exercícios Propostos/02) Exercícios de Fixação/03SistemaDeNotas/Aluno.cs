using System.Globalization;

namespace _03SistemaDeNotas
{
    class Aluno
    {
        public string NomeAluno;
        public double NotaPrimeiroTrimestre, NotaSegundoTrimestre, NotaTerceiroTrimestre;

        public double NotaFinal()
        {
            return NotaPrimeiroTrimestre + NotaSegundoTrimestre + NotaTerceiroTrimestre;
        }

        public string Resultado()
        {
            if (NotaFinal() >= 60.00)
            {
                return "APROVADO";
            }
            else
            {
                double pontosFaltantes = 60.00 - NotaFinal();
                return "REPROVADO\n" + "FALTARAM " + pontosFaltantes.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
            }
        }
    }
}
