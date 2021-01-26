namespace TaxSystem.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public const double FirstTaxRange = 0.15;
        public const double SecondTaxRange = 0.25;
        public const double HealthDeduction = 0.50;

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0.0;

            if (AnualIncome < 20000.00)
            {
                 tax = AnualIncome * FirstTaxRange - (HealthExpenditures * HealthDeduction);
            }
            else
            {
                tax = (AnualIncome * SecondTaxRange) - (HealthExpenditures * HealthDeduction);
            }

            return tax;
        }
    }
}
