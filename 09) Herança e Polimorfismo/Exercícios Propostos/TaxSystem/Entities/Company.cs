namespace TaxSystem.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public const double FirstTaxRange = 0.14;
        public const double SecondTaxRange = 0.16;

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double tax = 0.0;

            if (NumberOfEmployees < 10)
            {
                tax = AnualIncome * SecondTaxRange;
            }
            else
            {
                tax = AnualIncome * FirstTaxRange;
            }

            return tax;
        }
    }
}
