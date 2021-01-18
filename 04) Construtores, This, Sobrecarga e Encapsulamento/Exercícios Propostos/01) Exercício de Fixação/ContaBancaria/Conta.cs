using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        private string _nomeDoTitular;
        private int NumeroConta { get; set; }
        private double Saldo { get; set; }

        public Conta(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeDoTitular = nomeTitular;
        }

        public Conta(int numeroConta, string nomeTitular, double valorInicial) : this(numeroConta, nomeTitular)
        {
            Saldo = valorInicial;
        }

        public string NomeDoTitular
        {
            get { return _nomeDoTitular; }
            set
            {
                if (value != null && value.Length > 4)
                {
                    _nomeDoTitular = value;
                }
            }
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor + 5.0;
        }

        public override string ToString()
        {
            return "Dados da conta:\n"
                + "Conta "
                + NumeroConta
                + ", "
                + "Titular: "
                + NomeDoTitular
                + ", "
                + "Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
