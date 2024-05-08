using System;

namespace ReferenceNumberGenerator
{
    public class SpecialDigitCalculator
    {
        public static char CalculateSpecialDigit(string value)
        {
            // Initialize variables for A, B, C, D, and E
            int A = 0, B = 0, C = 0, D = 0, E = 0;

            // Iterate through the digits of the value
            for (int i = 0; i < value.Length; i++)
            {
                int digit = int.Parse(value[i].ToString());

                // Calculate A, B, C, D, and E based on their respective multipliers
                switch (i % 5)
                {
                    case 0:
                        A += digit * 10;
                        break;
                    case 1:
                        B += digit * 8;
                        break;
                    case 2:
                        C += digit * 6;
                        break;
                    case 3:
                        D += digit * 4;
                        break;
                    case 4:
                        E += digit * 2;
                        break;
                }
            }

            // Calculate the final sum
            int finalSum = A + B + C + D + E;

            // Reduce the final sum to a single digit
            int specialDigit = ReduceToSingleDigit(finalSum);

            return char.Parse(specialDigit.ToString());
        }

        private static int ReduceToSingleDigit(int num)
        {
            while (num > 9)
            {
                int sum = 0;
                while (num != 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                num = sum;
            }
            return num;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string value = "9729923302749217";
            char specialDigit = SpecialDigitCalculator.CalculateSpecialDigit(value);
            Console.WriteLine($"The special digit for the value {value} is '{specialDigit}'.");
        }
    }
}
