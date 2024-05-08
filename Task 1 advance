using System;

namespace LoanCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double targetMonthlyInstallment = 1750; // Target monthly installment
            double principal = 95000; // Principal amount borrowed
            double interestRate; // Monthly interest rate
            int years = 1; // Starting loan period in years
            int maxYears = 50; // Maximum loan period in years

            // Find the loan period required to achieve the target monthly installment
            while (years <= maxYears)
            {
                // Calculate the monthly interest rate based on the principal amount
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

                // Calculate the monthly installment (EMI)
                double monthlyInstallment = principal * interestRate * Math.Pow(1 + interestRate, numberOfPayments) / (Math.Pow(1 + interestRate, numberOfPayments) - 1);

                // Check if the monthly installment is within the target range
                if (monthlyInstallment <= targetMonthlyInstallment)
                {
                    Console.WriteLine($"The loan period required to achieve a monthly installment of RM {targetMonthlyInstallment:F2} or less is approximately {years} years.");
                    return;
                }

                years++; // Increment the loan period for the next iteration
            }

            Console.WriteLine($"The loan period required to achieve a monthly installment of RM {targetMonthlyInstallment:F2} or less exceeds the maximum allowable period.");
        }
    }
}
