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
        /// <returns>Result</returns>
        public static double Abs(double input)
        {
            if (input < 0)
                return -input;
            else
                return input;
        }
        /// <summary>
        /// Returns a factorial of the input number.
        /// </summary>
        /// <returns>Result</returns>
        public static double Factorial(double input)
        {
            // TODO
            return input;
        }
        /// <summary>
        /// Returns input^exponent.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="exponent"></param>
        /// <returns>Result</returns>
        public static double Power(double input, int exponent)
        {
            // TODO
            return input;
        }
        /// <summary>
        /// Returns exponent-th square root of an input.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="exponent"></param>
        /// <returns>Result</returns>
        public static double SquareRoot(double input, int exponent)
        {
            // TODO
            return input;
        }

        /// <summary>
        /// Returns decadic logarithm of an input.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="exponent"></param>
        /// <returns>Result</returns>
        public static double Logarithm(double input)
        {
            // TODO
            return input;
        }

    }
}
