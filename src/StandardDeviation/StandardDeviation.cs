using System;
using System.Globalization;
using Math;

namespace StandardDeviation
{
    public class StandardDeviationClass
    {
        /// <summary>
        ///     Converts the string of numbers to an array of numbers.
        /// </summary>
        /// <param name="input">Input to parse.</param>
        /// <returns>Array of doubles.</returns>
        public static double[] GetNumbersFromString(string input)
        {
            string[] splitInput = input.Split(' ', '\n', '\t');
            double[] numbers = new double[splitInput.Length];

            for (int i = 0; i < splitInput.Length; i++)
                numbers[i] = double.Parse(splitInput[i],
                    NumberStyles.AllowHexSpecifier | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign |
                    NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite, CultureInfo.InvariantCulture);

            return numbers;
        }

        /// <summary>
        ///     Counts the standard deviation.
        /// </summary>
        /// <param name="numbers">Data to count the standard deviation from.</param>
        /// <returns>Standard deviation.</returns>
        public static double CountStandardDeviation(double[] numbers)
        {
            double sum = 0;
            double poweredSum = 0;
            if (numbers.Length == 1)
                throw new DivideByZeroException();

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
            double[] numbers = GetNumbersFromString(input);
            Console.WriteLine(CountStandardDeviation(numbers));
        }
    }
}