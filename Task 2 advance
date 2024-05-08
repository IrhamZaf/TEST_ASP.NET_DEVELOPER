using System;
using System.Collections.Generic;
using System.Linq;

namespace SpecialDigitFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> frequencyMap = new Dictionary<char, int>();

            for (int number = 201; number <= 999; number++)
            {
                string value = number.ToString();
                char specialDigit = CalculateSpecialDigit(value);

                if (!frequencyMap.ContainsKey(specialDigit))
                {
                    frequencyMap[specialDigit] = 0;
                }

                frequencyMap[specialDigit]++;
            }

            // Sort the frequency map by special digit values
            var sortedFrequencyMap = frequencyMap.OrderBy(pair => pair.Key);

            Console.WriteLine("Special Digit Frequencies:");
            foreach (var entry in sortedFrequencyMap)
            {
                Console.WriteLine($"Special Digit: {entry.Key}, Frequency: {entry.Value}");
            }

            List<char> highestFrequencyDigits = new List<char>();
            int highestFrequency = 0;
            int lowestFrequency = int.MaxValue;
            char lowestFrequencyDigit = '0';

            foreach (var entry in frequencyMap)
            {
                if (entry.Value > highestFrequency)
                {
                    highestFrequency = entry.Value;
                    highestFrequencyDigits.Clear();
                    highestFrequencyDigits.Add(entry.Key);
                }
                else if (entry.Value == highestFrequency)
                {
                    highestFrequencyDigits.Add(entry.Key);
                }

                if (entry.Value < lowestFrequency)
                {
                    lowestFrequency = entry.Value;
                    lowestFrequencyDigit = entry.Key;
                }
            }

            Console.WriteLine("Special Digit(s) with Highest Frequency:");
            foreach (char digit in highestFrequencyDigits)
            {
                Console.WriteLine($"Special Digit: {digit}, Frequency: {highestFrequency}");
            }

            Console.WriteLine($"Special Digit with Lowest Frequency: {lowestFrequencyDigit}, Frequency: {lowestFrequency}");
        }

        static char CalculateSpecialDigit(string value)
        {
            int A = 0, B = 0, C = 0, D = 0, E = 0;

            for (int i = 0; i < value.Length; i++)
            {
                int digit = int.Parse(value[i].ToString());

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

            int finalSum = A + B + C + D + E;
            int specialDigit = ReduceToSingleDigit(finalSum);

            return char.Parse(specialDigit.ToString());
        }

        static int ReduceToSingleDigit(int num)
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
}
