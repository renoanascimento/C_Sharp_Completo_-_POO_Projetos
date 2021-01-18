namespace ConversorEstatico
{
    static class ConversorDeMoeda
    {
        public static double IOF = 1.06;

        public static double ConversorComIOF(double cotacao, double valorParaCompra)
        {
            double valorConvertido = cotacao * valorParaCompra;
            double valorComIOF = valorConvertido * IOF;
            return valorComIOF;
        }
    }
}
