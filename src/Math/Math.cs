using System;
using System.Collections.Generic;
using System.Globalization;

/// <summary>
/// Provides mathematical operations and functions.
/// </summary>
namespace Math
{
    /// <summary>
    /// Provides mathematical operations and functions.
    /// </summary>
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
                case 'P':
                    return 5;
            }

            return -1;
        }

        /// <summary>
        ///     Converts an expression in infix format to an expression in postfix format.
        ///     Supported operators and functions: + - * / ^ Abs(num) Log(num) Root(num,index).
        ///     Supported constants : e PI(entered as unicode character U+03C0).
        /// </summary>
        /// <param name="input">Infix expression</param>
        /// <returns>Postfix expression</returns>
        /// <exception cref="FormatException">When expression is in invalid format uses unsupported operators, functions or constants.</exception>
        public static string InfixToPostfix(string input)
        {
            Stack<char> stack = new Stack<char>();
            IList<char> operators = new List<char> { '-', '+', '*', '/', '^' }; //List of supported operators

            if (input.Split('(').Length != input.Split(')').Length) // Check if all brackets were closed
                throw new FormatException("Not all brackets were closed or opened");

            input = input.Replace("Abs", "A"); //Replace names of function with short versions (makes conversion easier)
            input = input.Replace("Log", "L");
            input = input.Replace("Root", "R");
            input = input.Replace("Pow", "P");
            //Edits to make signed numbers work:
            input = input.Replace(" ", ""); // Delete all spaces
            int openedBracketsCnt = 0;
            if (input[0] == '-' || input[0] == '+') {
                //Leading negative number (or positive number with + sign but no operand to add to)
                int numEndIndex = 1;
                while (numEndIndex < input.Length &&
                       (char.IsLetterOrDigit(input[numEndIndex]) || input[numEndIndex] == '.' || input[numEndIndex] == '(' || openedBracketsCnt > 0)) {
                    if (input[numEndIndex] == '(') openedBracketsCnt++;
                    if (input[numEndIndex] == ')') openedBracketsCnt--;
                    numEndIndex++;
                }
                input = "(0" + input; //Insert opening bracket and 0 infront of the number
                input = input.Insert(numEndIndex + 2, ")"); // Insert closing bracket at the end of the number
            }
            operators.Add('('); // Add opening bracket to the list of operators ( ONLY for checking signed numbers )
            foreach (char op in operators)
                while (input.Contains(op + "-") || input.Contains(op + "+")) {
                    //Signed number after an operator
                    int minusIndex = input.IndexOf(op + "-");
                    int plusIndex = input.IndexOf(op + "+");
                    int index = 0;
                    if (minusIndex == -1) index = plusIndex;
                    else if (plusIndex == -1) index = minusIndex;
                    else index = minusIndex < plusIndex ? minusIndex : plusIndex;
                    input = input.Insert(index + 1, "(0"); //Add opening bracket and 0 infront of the sign
                    openedBracketsCnt = 0;
                    int loopIndex = index + 4; // Index of the first digit of the signed number
                    while (loopIndex < input.Length &&
                           (char.IsLetterOrDigit(input[loopIndex]) || input[loopIndex] == '.' || input[loopIndex] == '(' || openedBracketsCnt > 0)
                    ) { //Gets to the end of the signed number
                        if (input[loopIndex] == '(') openedBracketsCnt++;
                        if (input[loopIndex] == ')') openedBracketsCnt--;
                        loopIndex++;

                    }
                    input = input.Insert(loopIndex, ")"); // Insert the closing bracket
                }

            operators.Remove('('); // Remove the opening bracket from list of operators

            char[] specialFuncs = { 'A', 'L', 'R', 'P' };

            // Topmost number of the stack currentFunc represents wheter c is inside of a function(Abs,Log,Root) and which one.
            // -1 = Not in a function, 0 = in Abs, 1 = in Log, 2 = in Root 3 = in Pow (corresponds with indexes of specialFuncs)
            Stack<int> currentFunc = new Stack<int>();
            currentFunc.Push(-1); // Set the initial state to -1 = not in any function

            bool ignoreOpeningBracket = false;
            bool insideNormalBrackets = false;
            openedBracketsCnt = 0;
            int bracketsOpenedInsideFunc = 0;
            string postfix = "";
            // Start of the core algorithm :
            for (int i = 0; i < input.Length; i++) {
                char c = input[i];
                if (char.IsLetterOrDigit(c) || c == '.') {
                    // Character is operand (number or constant) or one of (Abs, Log, Root)
                    if (char.IsLetter(c)) {
                        if (c == 'π' || c == 'e' || c == 'E') {
                            if (i != 0 && !operators.Contains(input[i - 1]) && input[i - 1] != ',' && input[i - 1] != '('
                            ) // Infront of this constant there is another operand
                                postfix += c + " * "; // Add multiplication in betwen the two operands
                            else
                                postfix += c; // There is an operator infront of the constant 
                        }
                        else if (c == 'A' || c == 'L' || c == 'R' || c == 'P') {
                            ignoreOpeningBracket = true;
                            for (int j = 0; j < specialFuncs.Length; j++) {
                                if (c == specialFuncs[j])
                                    currentFunc.Push(j);
                            }
                            if (i != 0 && !operators.Contains(input[i - 1]) && input[i - 1] != '(' && input[i - 1] != ',') {
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
                        if (currentFunc.Peek() != -1) bracketsOpenedInsideFunc++;
                        //Not a bracket of a function
                        if (i != 0 && !operators.Contains(input[i - 1]) && input[i - 1] != '(' && input[i - 1] != ',') {
                            // Implicit multiplication of brackets ( 3(2) => 3*(2) )
                            stack.Push('*');
                            postfix += " ";
                        }

                        stack.Push(c);
                        openedBracketsCnt++;
                        insideNormalBrackets = true;
                    }
                    else { // Is opening bracket of a function -> will be ignored
                        ignoreOpeningBracket = false;
                        insideNormalBrackets = false;
                    }
                }
                else if (c == ')') {
                    if (i != input.Length - 1 && !operators.Contains(input[i + 1]) && input[i + 1] != 'e' &&
                        input[i + 1] != 'E' && input[i + 1] != 'π' && input[i + 1] != ')' &&
                        input[i + 1] != ',')
                        throw new FormatException("Syntax error: A number directly following a closing bracket.");
                    if (currentFunc.Peek() != -1 && bracketsOpenedInsideFunc == 0) { // Closing bracket of a function inside of brackets
                        while (stack.Peek() != '[') {
                            if (operators.Contains(stack.Peek())) //Next char is operator -> put a space infront of it
                                postfix += ' ';
                            postfix += stack.Pop();
                        }
                        stack.Pop(); // Get rid of the [
                        postfix += " " + specialFuncs[currentFunc.Peek()]; // Add the special function
                        currentFunc.Pop();

                    }
                    else if (currentFunc.Count > 2 && !insideNormalBrackets) {
                        postfix += " " + specialFuncs[currentFunc.Pop()];
                        stack.Pop(); // get rid of [
                    }
                    else {
                        if (currentFunc.Peek() != -1) bracketsOpenedInsideFunc--;
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
                        insideNormalBrackets = false;
                        if (functionBracketEncountered) stack.Push('[');
                    }
                }
                else if (c == ',') {
                    // Separator of values inside Root
                    if (currentFunc.Peek() != 2 && currentFunc.Peek() != 3) // comma is only allowed inside of Root and Power
                        throw new FormatException("Stray comma");
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
                        throw new FormatException("Unsupported character");
                    if (i != 0 && c != '-' && operators.Contains(input[i - 1]))
                        throw new FormatException("Syntax error: two operators next to each other"); // Syntax error : Two operators next to each other
                    if (stack.Count == 0 || Prec(c) > Prec(stack.Peek())) {
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
        ///     Processes a string input, performs all the operations in a correct order and returns the result.
        ///     Supported operators and functions: + - * / ^ Abs(num) Log(num) Root(num,index) Pow(num,exponent).
        ///     Supported constants : e PI(entered as unicode character U+03C0).
        ///     Uses dot as decimal separator.
        /// </summary>
        /// <param name="input">Expression to proccess</param>
        /// <returns>Result of given mathematical expression.</returns>
        /// <exception cref="FormatException">When expression is in invalid format uses unsupported operators, functions or constants.</exception>
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
                    try {
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
                            case 'P': //Power
                                operand2 = stack.Pop();
                                operand1 = stack.Pop();
                                stack.Push(Power(operand1, operand2));
                                break;
                        }
                    }
                    catch (InvalidOperationException) {  // InvalidOperationException("Stack is empty") is thrown, when the given expression has invalid syntax, and the error wasn't detected in InfixToPostfix.
                        throw new FormatException("Syntax error"); //Throw FormatException("Syntax error") instead, as it provides more usefull information to the user.
                    }
                }
            }
            if (readingNumber) { // Solves the special case when only a constant was entered without any operations.
                stack.Push(double.Parse(numBuff,
                    NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign |
                    NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite,
                    CultureInfo.InvariantCulture)); //Push the number to the stack
            }
            if (stack.Count != 1) throw new FormatException("Syntax error");
            return stack.Pop();
        }

        /// <summary>
        ///     Adds one number to another.
        /// </summary>
        /// <param name="inputA">First number</param>
        /// <param name="inputB">Second number</param>
        /// <returns>The two numbers added together.</returns>
        /// <exception cref="FormatException">When expression is in invalid format uses unsupported operators, functions or constants.</exception>
        public static double Add(double inputA, double inputB)
        {
            return inputA + inputB;
        }

        /// <summary>
        ///     Substracts one number from another.
        /// </summary>
        /// <param name="inputA">Number to be subtracted from</param>
        /// <param name="inputB">Number to subtract</param>
        /// <returns>Result of subtracting inputB from inputA.</returns>
        public static double Subtract(double inputA, double inputB)
        {
            return inputA - inputB;
        }

        /// <summary>
        ///     Divides one number by another.
        /// </summary>
        /// <param name="inputA">dividend</param>
        /// <param name="inputB">divisor</param>
        /// <returns>Dividend divided by divisor.</returns>
        /// <exception cref="DivideByZeroException">When the inputB is zero.</exception>
        public static double Divide(double inputA, double inputB)
        {
            if (inputB == 0) throw new DivideByZeroException("Division by zero attempted");
            return inputA / inputB;
        }

        /// <summary>
        ///     Multiplies one number by another.
        /// </summary>
        /// <param name="inputA">First number</param>
        /// <param name="inputB">Second number</param>
        /// <returns>First number multiplied by second number.</returns>
        public static double Multiply(double inputA, double inputB)
        {
            return inputA * inputB;
        }


        /// <summary>
        ///     Calculates absolute value of a number.
        /// </summary>
        /// <param name="input">Number</param>
        /// <returns>Absolute value of the number.</returns>
        public static double Abs(double input)
        {
            if (input < 0)
                return -input;
            return input;
        }

        /// <summary>
        ///     Calculates the factorial of a number. Only supports positive integers and zero.
        /// </summary>
        /// <param name="input">Number</param>
        /// <returns>Factorial of the number.</returns>
        /// <exception cref="ArgumentOutOfRangeException">When input is not nonnegative integer.</exception>
        public static double Factorial(double input)
        {
            if (input < 0.0 || input % 1 != 0.0 || input > 170) throw new Exception("Unsupported operation");
            double result = 1;
            for (double i = 2; i <= input; i++)
                result = (result * i);
            return result;
        }

        /// <summary>
        ///     Raises a number to a given power.
        /// </summary>
        /// <param name="input">Base number</param>
        /// <param name="exponent">Exponent</param>
        /// <returns>Base number raised to the exponent.</returns>
        /// <exception cref="NotFiniteNumberException">When the result is not a valid number.</exception>
        public static double Power(double input, double exponent)
        {
            double result = System.Math.Pow(input, exponent);
            if (double.IsInfinity(result) || double.IsNaN(result)) throw new NotFiniteNumberException("Number is too big");

            return result;
        }

        /// <summary>
        ///     Calculates the n-th root of a number.
        /// </summary>
        /// <param name="radicand">number</param>
        /// <param name="index">index</param>
        /// <returns>Index-th root of the number.</returns>
        /// <exception cref="ArithmeticException">When the index is 0 or even in combination with negative radicant.</exception>
        public static double Root(double radicand, double index)
        {
            if (index == 0 || index % 2 == 0 && radicand < 0) throw new ArithmeticException("Math error");
            double result = System.Math.Pow(System.Math.Abs(radicand), 1.0 / index);
            if (radicand < 0) result = -result;
            return result;
        }

        /// <summary>
        ///     Calculates the decadic logarithm of a number.
        /// </summary>
        /// <param name="input">number</param>
        /// <returns>Base 10 logarithm of the number.</returns>
        /// <exception cref="NotFiniteNumberException">When the result is not a valid number.</exception>
        public static double Logarithm(double input)
        {
            double result = System.Math.Log10(input);
            if (double.IsInfinity(result) || double.IsNaN(result)) throw new NotFiniteNumberException("Number is too big");
            return result;
        }
    }
}
