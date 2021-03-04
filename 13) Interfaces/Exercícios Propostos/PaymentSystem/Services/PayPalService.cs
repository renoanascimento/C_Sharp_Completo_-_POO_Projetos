using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentSystem.Services
{
    class PayPalService : ITaxService
    {
        public const double SIMPLE_INTEREST = 1.00;
        public const double PAYMENT_TAX = 1.02;

        public double Tax(double amount, int numberOfInstallment)
        {
            double installmentValue = 0.0, installmentTotalValue = 0.0;
            installmentValue = amount * (SIMPLE_INTEREST + (numberOfInstallment / 100.0));
            installmentTotalValue = installmentValue * PAYMENT_TAX;

            return installmentTotalValue;
        }
    }
}
