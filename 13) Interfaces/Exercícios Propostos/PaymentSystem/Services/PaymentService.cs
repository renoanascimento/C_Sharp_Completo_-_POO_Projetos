using PaymentSystem.Entities;

namespace PaymentSystem.Services
{
    class PaymentService
    {
        public int InstallmentsNumber { get; set; }

        private ITaxService _taxService;

        public PaymentService(int installmentsNumber, ITaxService taxService)
        {
            InstallmentsNumber = installmentsNumber;
            _taxService = taxService;
        }

        public void ProcessInstallment(Contract contract)
        {
            double installmentAmount = contract.TotalValue / InstallmentsNumber;

            for (int i = 1; i <= InstallmentsNumber; i++)
            {
                double totalInstallment = 0.0;
                totalInstallment = _taxService.Tax(installmentAmount, i);
                Installment installment = new Installment(contract.Date.AddMonths(i), totalInstallment);
                contract.Installments.Add(installment);
            }
        }
    }
}
