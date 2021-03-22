using System;
using Math;
namespace StandardDeviation
{
    class StandardDeviation
    {
        /// <summary>
        /// Counts the standard deviation.
        /// </summary>
        /// <param name="sum">Total summary of all numbers</param>
        /// <param name="numbers">Array of given numbers to count the standard deviation from</param>
        /// <returns>Result</returns>
        static double CountStandardDeviation(double sum, double []numbers)
        {
            double average = sum / numbers.Length;
            double poweredSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                poweredSum += MathClass.Power(numbers[i], 2);
            }
            double sumOfDeviations = poweredSum - numbers.Length * MathClass.Power(average, 2);
            double result = MathClass.Root(sumOfDeviations / (numbers.Length - 1), 2);
            return result;
        }
        static void Main(string[] args)
        {
            string a;
            string[] cisla;
            a = Console.ReadLine();
            cisla = a.Split(' ', '\n');
            double[] numbers = new double[cisla.Length];
            double sum = 0;
            //Checking whether the correct input is given.
            try
            {
                for (int i = 0; i < cisla.Length; i++)
                {
                    numbers[i] = Double.Parse(cisla[i]);
                    sum += numbers[i];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(CountStandardDeviation(sum, numbers));
        }
    }
}
