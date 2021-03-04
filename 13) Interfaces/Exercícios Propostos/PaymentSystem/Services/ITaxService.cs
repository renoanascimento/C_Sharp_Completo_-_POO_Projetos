namespace PaymentSystem.Services
{
    interface ITaxService
    {
        double Tax(double amount, int numberInstallments);
    }
}
