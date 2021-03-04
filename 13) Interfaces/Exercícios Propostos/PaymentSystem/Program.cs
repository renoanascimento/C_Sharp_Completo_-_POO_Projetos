using System;
using System.Globalization;
using PaymentSystem.Entities;
using PaymentSystem.Services;

namespace PaymentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int installmentsNumber = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);

            PaymentService paymentService = new PaymentService(installmentsNumber, new PayPalService());

            paymentService.ProcessInstallment(contract);

            Console.WriteLine("Installments:");

            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment.DueDate.ToString("dd/MM/yyyy") + " - " + installment.Amount.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
