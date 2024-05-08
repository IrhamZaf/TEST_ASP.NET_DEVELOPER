using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateMonthlyRepayment();
        }

        static void CalculateMonthlyRepayment()
        {
            // Loan details
            double principal = 95000; // Principal amount borrowed
            int years = 5; // Loan period in years

            // Interest rates
            double interestRate;
            if (principal >= 5000 && principal <= 20000)
            {
                interestRate = 0.08 / 12; // 8% per annum fixed rate
            }
            else if (principal > 20000 && principal <= 50000)
            {
                interestRate = 0.07 / 12; // 7% per annum fixed rate
            }
            else if (principal > 50000 && principal <= 100000)
            {
                interestRate = 0.065 / 12; // 6.5% per annum fixed rate
            }
            else
            {
                Console.WriteLine("Loan amount not within the specified range.");
                return;
            }

            int numberOfPayments = years * 12; // Total number of payments

            // Calculate monthly installment (EMI)
            double monthlyInstallment = principal * interestRate * Math.Pow(1 + interestRate, numberOfPayments) / (Math.Pow(1 + interestRate, numberOfPayments) - 1);

            Console.WriteLine($"The monthly repayment is RM {monthlyInstallment:F2}.");
        }
    }
}
