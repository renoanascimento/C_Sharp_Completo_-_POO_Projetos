using System;
using IntroDelegates.Services;

namespace IntroDelegates
{
    class Program
    {
        delegate void BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;
            //BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);

            op.Invoke(a, b);
            //op(a, b);
        }
    }
}
