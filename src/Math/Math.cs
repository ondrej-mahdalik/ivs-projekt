using System;
namespace Math
{
   
    public class MathClass
    {
        /// <summary>
        /// Processes string input, performs all operations in correct order.
        /// </summary>
        /// <param name="input">Text to proccess</param>
        /// <returns>Final result</returns>
        public static double FromString(string input)
        {
            // TODO
            return 0.0;
        }

        /// <summary>
        /// Adds one number to another.
        /// </summary>
        /// <param name="inputA">Number to proccess</param>
        /// <param name="inputB">Number to proccess</param>
        /// <returns>Result</returns>
        public static double Add(double inputA, double inputB)
        {
            return inputA + inputB;
        }

        /// <summary>
        /// Substracts one number from another.
        /// </summary>
        /// <param name="inputA">Number to subtract from</param>
        /// <param name="inputB">Number to </param>
        /// <returns>Result</returns>
        public static double Subtract(double inputA, double inputB)
        {
            return inputA - inputB;
        }

        /// <summary>
        /// Divides one number by another.
        /// </summary>
        /// <param name="inputA"></param>
        /// <param name="inputB"></param>
        /// <returns>Result</returns>
        public static double Divide(double inputA, double inputB)
        {
            return inputA / inputB;
        }

        /// <summary>
        /// Multiplies one number by another.
        /// </summary>
        /// <param name="inputA"></param>
        /// <param name="inputB"></param>
        /// <returns>Result</returns>
        public static double Multiply(double inputA, double inputB)
        {
            return inputA * inputB;
        }


        /// <summary>
        /// Returns the absolute value of the input number.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Result</returns>
        public static double Abs(double input)
        {
            if (input < 0)
                return -input;
            else
                return input;
        }
        /// <summary>
        /// Returns a factorial of the input number. Only supports whole numbers.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Result</returns>
        public static double Factorial(double input)
        {
            if(input < 0.0 || input % 1 != 0.0) {
                throw new ArgumentOutOfRangeException();
            }
            ulong result = 1;
            for(ulong i = 2; i <= input; i++) {
                result = checked(result * i); // checked keyword - checks for overflow and in case of overflow throws a Run-time exception
            }
            return result;
        }
        /// <summary>
        /// Returns input^exponent.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="exponent"></param>
        /// <returns>Result</returns>
        public static double Power(double input, double exponent)
        {

            double result = System.Math.Pow(input,exponent);
            if(double.IsInfinity(result) || double.IsNaN(result)) {
                throw new NotFiniteNumberException();
            }
            
            return result;
        }
        /// <summary>
        /// Returns index-th root of a radicant.
        /// </summary>
        /// <param name="radicant"></param>
        /// <param name="index"></param>
        /// <returns>Result</returns>
        public static double SquareRoot(double radicant, double index)
        {
            if(index == 0) {
                throw new DivideByZeroException();
            }
            return System.Math.Pow(radicant,1.0 / index);
        }

        /// <summary>
        /// Returns the decadic logarithm of input.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Result</returns>
        public static double Logarithm(double input)
        {
            double result = System.Math.Log(input, 10);
            if (double.IsInfinity(result) || double.IsNaN(result)) {
                throw new NotFiniteNumberException();
            }
            return result;
        }

    }
}
