using System;
namespace Math
{
   
    public class MathClass
    {
        /// <summary>
        /// Utility function that returns the precedence of given operator.
        /// Higher value means higher precedence (is evaluated sooner)
        /// </summary>
        /// <param name="ch"></param>
        /// <returns>Precendence</returns>
        internal static int Prec(char ch)
        {
            switch (ch) {
                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                    return 2;

                case '^':
                    return 3;
            }
            return -1;
        }
        /// <summary>
        /// Converts expression in infix format to expression in postfix format
        /// Inserts space between operands and after each operator(excluding the last one)
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Postfix expression</returns>
        public static string InfixToPostfix(string input)
        {
            System.Collections.Generic.Stack<char> stack = new System.Collections.Generic.Stack<char>();
            System.Collections.Generic.IList<char> operators = new System.Collections.Generic.List<char> { '+', '-', '*', '/' }; //List of supported operators
            string postfix = "";
            for (int i = 0; i < input.Length; i++) {
                char c = input[i];
                if (Char.IsWhiteSpace(c)) continue; //Ignore whitespace characters
                if (Char.IsLetterOrDigit(c) || c == '.') { //If character is operand (number or constant) add it to the postfix expression
                    if (Char.IsLetter(c)) {
                        if (c != 'π' || c != 'e') {
                            throw new NotSupportedException();
                        }
                    }
                    postfix += c;
                }
                else if (c == '(') {
                    stack.Push(c);
                }
                else if (c == ')') { //Pop from stack to output until '(' is encountered
                    while (stack.Count > 0 && stack.Peek() != '(') {
                        postfix += stack.Pop();
                        if(stack.Peek() != '.' || !Char.IsLetterOrDigit(stack.Peek())) { //Popped last digit of a number, insert space
                            postfix += ' ';
                        }
                    }
                    if (stack.Count > 0 && stack.Peek() != '(') { // Invalid expression - unclosed brackets
                        throw new FormatException();
                    }
                    else {
                        stack.Pop(); //Gets rid of the '(' in stack
                    }
                }
                else { //Character is (probably) operator
                    if (!operators.Contains(c)) { // Char is not a number or one of the supported operators -> throws exception
                        throw new NotImplementedException();
                    }
                    if (stack.Count == 0 || Prec(c) >= Prec(stack.Peek()) || stack.Contains('(')) {
                        stack.Push(c);
                   //     stack.Push(' ');
                        postfix += ' ';
                    }
                    else {
                        while (stack.Count > 0 && Prec(stack.Peek()) >= Prec(c)) {
                            postfix += stack.Pop();
                            postfix += ' ';
                        }
                        stack.Push(c);
                    }
                }
            }
            while (stack.Count > 0) {
                postfix += stack.Pop();
                if (stack.Count != 0 && ( stack.Peek() != '.' || !Char.IsLetterOrDigit(stack.Peek()) ) ) { //Popped last digit of a number -> insert space into result
                    postfix += ' ';
                }
            }
            while(postfix.Contains("  ")) { //Replaces multiple spaces with one
                postfix = postfix.Replace("  ", " ");
            }
            return postfix;
        }


        /// <summary>
        /// Processes string input, performs all operations in correct order.
        /// Uses dot as decimal separator. 
        /// </summary>
        /// <param name="input">Text to proccess</param>
        /// <returns>Final result</returns>
        public static double FromString(string input)
        {
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
            if(inputB == 0) {
                throw new DivideByZeroException();
            }
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
        public static double Root(double radicant, double index)
        {
            if(index == 0 || (index % 2 == 0 &&  radicant < 0)) {
                throw new ArithmeticException();
            }
            double result = System.Math.Pow(System.Math.Abs(radicant), 1.0 / index);
            if (radicant < 0) {
                result = -result;
            }
            return result;
        }

        /// <summary>
        /// Returns the decadic logarithm of input.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Result</returns>
        public static double Logarithm(double input)
        {
            double result = System.Math.Log10(input);
            if (double.IsInfinity(result) || double.IsNaN(result)) {
                throw new NotFiniteNumberException();
            }
            return result;
        }

    }
}
