using System;
using System.Collections.Generic;
using System.Globalization;

namespace Math
{
    public class MathClass
    {
        /// <summary>
        ///     Utility function that returns the precedence of given operator.
        ///     Higher value means higher precedence (is evaluated sooner)
        /// </summary>
        /// <param name="ch">Operator</param>
        /// <returns>Precendence</returns>
        internal static int Prec(char ch)
        {
            switch (ch) {
                case '-':
                    return 0;
                case '+'
                    : // Addition could have the same precedence as subtraction, but this way it corresponds to the way most people (and online tools) would perform the conversion (doesn't change the results)
                    return 1;

                case '*':
                case '/':
                    return 3;

                case '^':
                    return 4;
            }

            return -1;
        }

        /// <summary>
        ///     Converts expression in infix format to expression in postfix format
        ///     Supported operators and functions: + - * / ^ Abs(num) Log(num) Root(num,index)
        ///     Supported constants : e π
        /// </summary>
        /// <param name="input">Infix expression</param>
        /// <returns>Postfix expression</returns>
        public static string InfixToPostfix(string input)
        {
            Stack<char> stack = new Stack<char>();
            IList<char> operators = new List<char> {'-', '+', '*', '/', '^'}; //List of supported operators

            if (input.Split('(').Length != input.Split(')').Length)
                throw new FormatException("Not all brackets were closed or opened");

            input = input.Replace("Abs", "A"); //Replace names of function with short versions (makes conversion easier)
            input = input.Replace("Log", "L");
            input = input.Replace("Root", "R");
            //Edits to make negative numbers work:
            input = input.Replace(" ", ""); // Delete all spaces
            if (input[0] == '-') {
                //Leading negative number
                int numEndIndex = 1;
                while (numEndIndex < input.Length &&
                       (char.IsLetterOrDigit(input[numEndIndex]) || input[numEndIndex] == '.')) numEndIndex++;
                input = "(0" + input; //Insert opening bracket and 0 infront of the negative number
                input = input.Insert(numEndIndex + 2, ")"); // Insert closing bracket at the end of the number
            }

            operators.Add('('); // Add opening bracket to the list of operators ( ONLY for checking negative numbers )
            foreach (char op in operators)
                while (input.Contains(op + "-")) {
                    //Negative number after an operator
                    int index = input.IndexOf(op + "-");
                    input = input.Insert(index + 1, "(0"); //Add opening bracket and 0 infront of the minus
                    int loopIndex = index + 4; // Index of the first digit of the negative number
                    while (loopIndex < input.Length &&
                           (char.IsLetterOrDigit(input[loopIndex]) || input[loopIndex] == '.')
                    ) //Gets to the end of the negative number
                        loopIndex++;
                    input = input.Insert(loopIndex, ")"); // Insert the closing bracket
                }

            operators.Remove('('); // Remove the opening bracket from list of operators

            char[] specialFuncs = {'A', 'L', 'R'};

            //Represents wheter c is inside of a function(Abs,Log,Root) and which one. -1 = Not in a function, 0 = in Abs, 1 = in Log, 2 = in Root (corresponds with indexes of specialFuncs)
            int currentFunc = -1;
            bool ignoreOpeningBracket = false;
            int openedBracketsCnt = 0;
            int bracketsOpenedInsideFunc = 0;
            string postfix = "";
            //Start of the core algorithm :
            for (int i = 0; i < input.Length; i++) {
                char c = input[i];
                if (char.IsLetterOrDigit(c) || c == '.') {
                    // Character is operand (number or constant) or one of (Abs, Log, Root)
                    if (char.IsLetter(c)) {
                        //( π is considered a letter)
                        if (c == 'π' || c == 'e' || c == 'E') {
                            if (i != 0 && !operators.Contains(input[i - 1])
                            ) // Infront of this constant there is another operand
                                postfix += c + " * "; // Add multiplication in betwen the two operands
                            else
                                postfix += c; // There is an operator infront of the constant 
                        }
                        else if (c == 'A' || c == 'L' || c == 'R') {
                            ignoreOpeningBracket = true;
                            for (int j = 0; j < specialFuncs.Length; j++)
                                if (c == specialFuncs[j])
                                    currentFunc = j;
                            if (i != 0 && !operators.Contains(input[i - 1]) && input[i - 1] != '(') {
                                // Handle implicit multiplication ( 3Log(10) => 3*Log(10) )
                                stack.Push('*');
                                postfix += " ";
                            }

                            stack.Push('[');
                        }
                        else
                            throw new FormatException("Unsupported character: " + c);
                    }
                    else
                        postfix += c; // C is a digit
                }
                else if (c == '!') {
                    //Factorial
                    postfix += ' ';
                    postfix += c;
                }
                else if (c == '(') {
                    if (!ignoreOpeningBracket) {
                        if (currentFunc != -1) bracketsOpenedInsideFunc++;
                        //Not a bracket of a function
                        if (i != 0 && !operators.Contains(input[i - 1]) && input[i - 1] != '(' && input[i-1] != ',') {
                            // Implicit multiplication of brackets ( 3(2) => 3*(2) )
                            stack.Push('*');
                            postfix += " ";
                        }

                        stack.Push(c);
                        openedBracketsCnt++;
                    }
                    else // Is opening bracket of a function -> will be ignored
                        ignoreOpeningBracket = false;
                }
                else if (c == ')') {
                    if (i != input.Length - 1 && !operators.Contains(input[i + 1]) && input[i + 1] != 'e' &&
                        input[i + 1] != 'E' && input[i + 1] != 'π' && input[i + 1] != ')' &&
                        input[i + 1] != ',')
                        throw new FormatException("Syntax error: A number directly following a closing bracket.");
                    if(currentFunc != -1 && bracketsOpenedInsideFunc==0) { // Closing bracket of a function inside of brackets
                        while (stack.Peek() != '[') {
                            if (operators.Contains(stack.Peek())) //Next char is operator -> put a space infront of it
                                postfix += ' ';
                            postfix += stack.Pop();
                        }
                        stack.Pop(); // Get rid of the [
                        postfix += " " + specialFuncs[currentFunc]; // Add the special function
                        currentFunc = -1;

                    }
                    else {
                        if (currentFunc != -1) bracketsOpenedInsideFunc--;
                        bool functionBracketEncountered = false;
                        //Pop from stack to output until '(' is encountered
                        while (stack.Count > 0 && stack.Peek() != '(') {
                            if (operators.Contains(stack.Peek())) postfix += " ";
                            char popped = stack.Pop();
                            if (popped != '[') postfix += popped;
                            else functionBracketEncountered = true;
                            if (stack.Peek() != '.' || !char.IsLetterOrDigit(stack.Peek())
                            ) //Popped last digit of a number, insert space
                                postfix += ' ';
                        }

                        stack.Pop(); //Gets rid of the '(' in stack
                        openedBracketsCnt--;
                        if (functionBracketEncountered) stack.Push('[');
                    }
                }
                else if (c == ',') {
                    // Separator of values inside Root
                    if (currentFunc != 2) // comma is only allowed inside of Root
                        throw new FormatException("Comma is only allowed inside of Root");
                    while (stack.Peek() != '[') {
                        if (operators.Contains(stack.Peek())) //Next char is operator -> put a space infront of it
                            postfix += ' ';
                        postfix += stack.Pop();
                    }

                    postfix += " ";
                }
                else {
                    //Character should be an OPERATOR
                    if (!operators.Contains(c)) // Char is not one of the supported operators -> throws exception 
                        throw new FormatException("Char is not one of the supported operators");
                    if (i != 0 && c != '-' && operators.Contains(input[i - 1]))
                        throw new FormatException(); // Syntax error : Two operators next to each other
                    if (stack.Count == 0 || Prec(c) > Prec(stack.Peek()) || stack.Contains('(')) {
                        stack.Push(c);
                        postfix += ' ';
                    }
                    else {
                        while (stack.Count > 0 && Prec(stack.Peek()) >= Prec(c)) {
                            if (operators.Contains(stack.Peek())) //Next char is operator -> put a space infront
                                postfix += ' ';
                            postfix += stack.Pop();
                            postfix += ' ';
                        }

                        stack.Push(c);
                    }
                }
            }

            while (stack.Count > 0) {
                postfix += ' ';
                postfix += stack.Pop();
                postfix += ' ';
            }

            while (postfix.Contains("  ")) //Remove double spaces
                postfix = postfix.Replace("  ", " ");
            postfix = postfix.Trim(); //Remove leading and trailing spaces
            return postfix;
        }

        /// <summary>
        ///     Processes string input, performs all operations in correct order and returns result.
        ///     Supported operators and functions: + - * / ^ Abs(num) Log(num) Root(num,index)
        ///     Supported constants : e π
        ///     Uses dot as decimal separator
        /// </summary>
        /// <param name="input">Expression to proccess</param>
        /// <returns>Final result</returns>
        public static double FromString(string input)
        {
            if (input == string.Empty) throw new ArgumentNullException();
            string postfix = InfixToPostfix(input); // Converts the expression from infix notation to postfix notation
            Stack<double> stack = new Stack<double>();
            bool readingNumber = false;
            string numBuff = "";
            //Goes through the postfix expression, pushes numbers to stack, when operator (or function) is encountered, corresponding number of numbers is popped from the stack and the operation is performed, its result is pushed onto the stack. At the end only the final result remains in the stack
            for (int i = 0; i < postfix.Length; i++) {
                char c = postfix[i];
                if (char.IsDigit(c) || c == '.') {
                    // C is a part of a number
                    readingNumber = true;
                    numBuff += c;
                }
                else if (c == 'e' || c == 'E') // c is a constant
                    stack.Push(System.Math.E);
                else if (c == 'π')
                    stack.Push(System.Math.PI);
                else {
                    // c is an operator or a whitespace
                    if (readingNumber) {
                        // Was previously reading a number
                        stack.Push(double.Parse(numBuff,
                            NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign |
                            NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite,
                            CultureInfo.InvariantCulture)); //Push the number to the stack
                        numBuff = "";
                        readingNumber = false;
                    }

                    double operand1, operand2;
                    switch (c) {
                        // Performs the given operation on numbers on top of the stack and pushes the result to the stack
                        case '+':
                            operand2 = stack.Pop();
                            operand1 = stack.Pop();
                            stack.Push(Add(operand1, operand2));
                            break;
                        case '-':
                            operand2 = stack.Pop();
                            operand1 = stack.Pop();
                            stack.Push(Subtract(operand1, operand2));
                            break;
                        case '*':
                            operand2 = stack.Pop();
                            operand1 = stack.Pop();
                            stack.Push(Multiply(operand1, operand2));
                            break;
                        case '/':
                            operand2 = stack.Pop();
                            operand1 = stack.Pop();
                            stack.Push(Divide(operand1, operand2));
                            break;
                        case '^':
                            operand2 = stack.Pop();
                            operand1 = stack.Pop();
                            stack.Push(Power(operand1, operand2));
                            break;
                        case '!':
                            operand1 = stack.Pop();
                            stack.Push(Factorial(operand1));
                            break;
                        case 'A': //Abs
                            operand1 = stack.Pop();
                            stack.Push(Abs(operand1));
                            break;
                        case 'L': //Log
                            operand1 = stack.Pop();
                            stack.Push(Logarithm(operand1));
                            break;
                        case 'R': //Root
                            operand2 = stack.Pop();
                            operand1 = stack.Pop();
                            stack.Push(Root(operand1, operand2));
                            break;
                    }
                }
            }
            if (readingNumber) { // Solves the special case when only a constant was enetered without any operations.
                stack.Push(double.Parse(numBuff,
                    NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign |
                    NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite,
                    CultureInfo.InvariantCulture)); //Push the number to the stack
                numBuff = "";
                readingNumber = false;
            }

            return stack.Pop();
        }

        /// <summary>
        ///     Adds one number to another.
        /// </summary>
        /// <param name="inputA">Number to proccess</param>
        /// <param name="inputB">Number to proccess</param>
        /// <returns>Result</returns>
        public static double Add(double inputA, double inputB)
        {
            return inputA + inputB;
        }

        /// <summary>
        ///     Substracts one number from another.
        /// </summary>
        /// <param name="inputA">Number to subtract from</param>
        /// <param name="inputB">Number to </param>
        /// <returns>Result</returns>
        public static double Subtract(double inputA, double inputB)
        {
            return inputA - inputB;
        }

        /// <summary>
        ///     Divides one number by another.
        /// </summary>
        /// <param name="inputA"></param>
        /// <param name="inputB"></param>
        /// <returns>Result</returns>
        public static double Divide(double inputA, double inputB)
        {
            if (inputB == 0) throw new DivideByZeroException();
            return inputA / inputB;
        }

        /// <summary>
        ///     Multiplies one number by another.
        /// </summary>
        /// <param name="inputA"></param>
        /// <param name="inputB"></param>
        /// <returns>Result</returns>
        public static double Multiply(double inputA, double inputB)
        {
            return inputA * inputB;
        }


        /// <summary>
        ///     Returns the absolute value of the input number.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Result</returns>
        public static double Abs(double input)
        {
            if (input < 0)
                return -input;
            return input;
        }

        /// <summary>
        ///     Returns a factorial of the input number. Only supports whole numbers.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Result</returns>
        public static double Factorial(double input)
        {
            if (input < 0.0 || input % 1 != 0.0) throw new ArgumentOutOfRangeException();
            ulong result = 1;
            for (ulong i = 2; i <= input; i++)
                result = checked(result *
                                 i); // checked keyword - checks for overflow and in case of overflow throws a Run-time exception
            return result;
        }

        /// <summary>
        ///     Returns input^exponent.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="exponent"></param>
        /// <returns>Result</returns>
        public static double Power(double input, double exponent)
        {
            double result = System.Math.Pow(input, exponent);
            if (double.IsInfinity(result) || double.IsNaN(result)) throw new NotFiniteNumberException();

            return result;
        }

        /// <summary>
        ///     Returns index-th root of a radicant.
        /// </summary>
        /// <param name="radicant"></param>
        /// <param name="index"></param>
        /// <returns>Result</returns>
        public static double Root(double radicant, double index)
        {
            if (index == 0 || index % 2 == 0 && radicant < 0) throw new ArithmeticException();
            double result = System.Math.Pow(System.Math.Abs(radicant), 1.0 / index);
            if (radicant < 0) result = -result;
            return result;
        }

        /// <summary>
        ///     Returns the decadic logarithm of input.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Result</returns>
        public static double Logarithm(double input)
        {
            double result = System.Math.Log10(input);
            if (double.IsInfinity(result) || double.IsNaN(result)) throw new NotFiniteNumberException();
            return result;
        }
    }
}