using System;
using Math;
namespace StandardDeviation
{
    public class StandardDeviationClass
    {
        /// <summary>
        /// Converts the string of numbers to an array of numbers.
        /// </summary>
        /// <param name="input">Input to parse.</param>
        /// <returns>Array of doubles.</returns>
        public static double[] GetNumbersFromString(string input)
        {
            string[] splitInput = input.Split(' ', '\n');
            double[] numbers = new double[splitInput.Length];

            //Checking whether the correct input is given
            try {
                for (int i = 0; i < splitInput.Length; i++) {
                    numbers[i] = Double.Parse(splitInput[i]);
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                System.Environment.Exit(1);
            }
            return numbers;
        }
        /// <summary>
        /// Counts the standard deviation.
        /// </summary>
        /// <param name="input">Data to count the standard deviation from.</param>
        /// <returns>Standard deviation.</returns>
        public static double CountStandardDeviation(string input)
        {
            double[] numbers = GetNumbersFromString(input);
            double sum = 0;
            double poweredSum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
                poweredSum += MathClass.Power(numbers[i], 2);
            }
            double average = sum / numbers.Length;
            double sumOfDeviations = poweredSum - numbers.Length * MathClass.Power(average, 2);
            double result = MathClass.Root(sumOfDeviations / (numbers.Length - 1), 2);
            return result;
        }
        public static void Main(string[] args)
        {
            string input;
            input = Console.ReadLine();
            Console.WriteLine(CountStandardDeviation(input));
        }
    }
}
