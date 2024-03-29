using System;
using System.Globalization;
using Math;
/// <summary>
///     Calculates standard deviation of given numbers.
/// </summary>
namespace StandardDeviation
{
    /// <summary>
    ///     Calculates standard deviation of given numbers.
    /// </summary>
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
            double[] numbers = new double[splitInput.Length - 1]; //Last element in splitInput is ' '

            for (int i = 0; i < splitInput.Length - 1; i++)
                numbers[i] = double.Parse(splitInput[i], NumberStyles.AllowDecimalPoint |
                    NumberStyles.AllowLeadingSign | NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite,
                    CultureInfo.InvariantCulture);

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

            foreach (var t in numbers)
            {
                sum += t;
                poweredSum += MathClass.Power(t, 2);
            }

            double average = sum / numbers.Length;
            double sumOfDeviations = poweredSum - numbers.Length * MathClass.Power(average, 2);
            double result = MathClass.Root(sumOfDeviations / (numbers.Length - 1), 2);
            return result;
        }
        /// <summary>
        ///     Counts the standard deviation using the function FromString.
        /// </summary>
        /// <param name="numbers">Data to count the standard deviation from.</param>
        /// <returns>Standard deviation calculated with the FromString function.</returns>
        public static double CountStandardDeviationUsingFromString(double[] numbers){

            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            string expression =  "Root((1/";
            expression += numbers.Length - 1 + ")*";
            expression += "((";
            foreach(double num in numbers){
                expression += num.ToString(nfi) + "^2" + "+";
            }
            expression = expression.Remove(expression.Length - 1); // Odstran� + nav�c
            expression += ")-" + numbers.Length + "* (";
            expression += "(1/" + numbers.Length + ")*(";
            foreach(double num in numbers){
                expression += num.ToString(nfi) + "+";
            }
            expression = expression.Remove(expression.Length - 1); // Odstran� + nav�c
            expression += "))^2),2)";
            double result = MathClass.FromString(expression);
            return result;
        }
        /// <summary>
        ///     Reads numbers from standard input and prints standard deviation of them, calculated by two different methods.
        /// </summary>
        public static void Main(string[] args)
        {
            string input;
            string parsedInput = "\0";
            
            while ((input = Console.ReadLine()) != null) {
                parsedInput += input;
                parsedInput += ' '; //Number at the end of the line and number at the beginning of a new line need to be split

                //Reaching an empty line
                if (string.IsNullOrEmpty(input)) {
                    parsedInput = parsedInput.Remove(parsedInput.Length - 1);
                    break;
                }
            } 
            parsedInput = parsedInput.Substring(1); //First element is space so it needs to be removed 
            double[] numbers = GetNumbersFromString(parsedInput);  
            Console.WriteLine(CountStandardDeviation(numbers));
            Console.WriteLine(CountStandardDeviationUsingFromString(numbers));
        }
    }
}