using System.Globalization;

namespace ContaBancaria
{
    class ContaBancaria
    {
        private const double taxaSaque = 5.0;
        private string _nomeDoTitular;
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeDoTitular = nomeTitular;
        }

        public ContaBancaria(int numeroConta, string nomeTitular, double valorInicial) : this(numeroConta, nomeTitular)
        {
            Depositar(valorInicial);
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
            Saldo -= valor + taxaSaque;
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + NomeDoTitular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
