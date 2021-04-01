using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math;
using System;
using System.Collections.Generic;
using System.Text;
namespace Math.Tests
{
    
    [TestClass()]
        
    public class MathClassTests
    {
        double num1 = 4;
        double num2 = 8;
        [TestMethod()]
          
        /// <summary>
        /// Tests for all mathematic operations (+, -, *, /, factorial, power, square root, absolute value, logarithm).
        /// </summary>
        /// <returns>Test passes when all results are equal to all the expectations otherwise fails.</returns>
        public void AdditionTest()
        {
            double[] firstNums = { -5, 8, 1, 12, 22, -1874, 14, 89345.568, 10048456, -45424141 };
            double[] secondNums = { 97, -45, -4, 48, 0, 1, 64, 15478.7452, 97711, 1124764545 };
            double[] results = { 92, -37, -3, 60, 22, -1873, 78, 104824.3132, 10146167, 1079340404 };
            for (int i = 0; i < firstNums.Length; i++) {
                Assert.AreEqual(results[i], MathClass.Add(firstNums[i], secondNums[i]));
            }
           
        }
        
        [TestMethod()]
            
        public void SubtractionTest()
        {
            double[] firstNums = { 77037, 384123, 355650, -354355, -948273, -683466, -607284, -655947, -120826, -392668 };
            double[] secondNums = { 483350, -963900, 417916, -720190, -337876, 706894, -194072, 583598, -253494, 493696 };
            double[] results = { -406313, 1348023, -62266, 365835, -610397, -1390360, -413212, -1239545, 132668, -886364 };
            for (int i = 0; i < firstNums.Length; i++) {
                Assert.AreEqual(results[i], MathClass.Subtract(firstNums[i], secondNums[i]));
            }
        }
        [TestMethod()]
        public void MultiplicationTest()
        {
            double[] firstNums = { 5616, -8273, -5454, -4232, 6654, 5138, -7848, -4701, 7872, 1301 };
            double[] secondNums = { 8101, 2102, 8178, 3384, -1123, 2505, -6264, -5008, -7240, -9208 };
            double[] results = { 45495216, -17389846, -44602812, -14321088, -7472442, 12870690, 49159872, 23542608, -56993280, -11979608 };
            for (int i = 0; i < firstNums.Length; i++) {
                Assert.AreEqual(results[i], MathClass.Multiply(firstNums[i], secondNums[i]));
            }
        }
 
        [TestMethod()]    
        public void DivisionTest() 
        {
      
            double result = MathClass.Divide(num2, num1);            
            double expected = 2;        
            Assert.AreEqual(result, expected);
            Assert.ThrowsException<DivideByZeroException>(() => MathClass.Divide(num1, 0));
            result = MathClass.Divide(-53, -5);
            expected = 10.6;
            Assert.AreEqual(result, expected);
        }

        [TestMethod()]
        public void FactorialTest()
        {
            double[] firstNums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] results = { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };
            for (int i = 0; i < firstNums.Length; i++) {
                Assert.AreEqual(results[i], MathClass.Factorial(firstNums[i]));
            }
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => MathClass.Factorial(-4));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => MathClass.Factorial(2.46));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => MathClass.Factorial(-6.8));
        }
      
        [TestMethod()]
        public void PowerTest()
        {
            double[] bases = { 0, -4, 1, 25, 46.33, 100, -68.29 };
            int exponent = 2;
            double[] results = { 0, 16, 1, 625, 2146.4689, 10000, 4663.5241000000005 };
          
            for (int i = 0; i < bases.Length; i++) {
                Assert.AreEqual(results[i], MathClass.Power(bases[i], exponent));
            }
          
            exponent = 3;
            double[] results2 = {0, -64, 1, 15625, 99445.90413699999, 1000000, -318472.06078900007};
            for (int j = 0; j < bases.Length; j++) {
                Assert.AreEqual(results2[j], MathClass.Power(bases[j], exponent));
            }
            Assert.AreEqual(1,MathClass.Power(2, 0));
            Assert.ThrowsException<NotFiniteNumberException>(() => MathClass.Power(0, -2));
        }
      
        [TestMethod()]
        public void RootTest()
        {
            double[] bases = { 0, 4, 1, 25, 132.25, 100, 1000000 };
            int exponent = 2;
            double[] results = { 0, 2, 1, 5, 11.5, 10, 1000 };
            for (int i = 0; i < bases.Length; i++) {
                Assert.AreEqual(results[i], MathClass.Root(bases[i], exponent));
            }
          
            Assert.ThrowsException<ArithmeticException>(() => MathClass.Root(-6, 2));
            exponent = 3;
            double[] bases2 = { 27, -27, 11209.345272, 0, -1, 1520.875 };
            double[] results2 = { 3, -3, 22.379999999999995, 0, -1, 11.499999999999998};
            for (int j = 0; j < bases2.Length; j++) {
                Assert.AreEqual(results2[j], MathClass.Root(bases2[j], exponent));
            }
        }
      
        [TestMethod()]
        public void LogarithmTest()
        {
            double[] firstNums = { 1, 10, 100, 1000, 50, 300, 655, 2000 };
            double[] results = { 0, 1, 2, 3, 1.6989700043360187, 2.4771212547196626, 2.816241299991783, 3.3010299956639813 };
            for (int i = 0; i < firstNums.Length; i++) {
                Assert.AreEqual(results[i], (MathClass.Logarithm(firstNums[i])));
            }
        }

        [TestMethod()]
        public void AbsTest()
        {
            double[] numbers = { 1, -1, 200, -200, -420, -69.69 };
            double[] results = { 1, 1, 200, 200, 420, 69.69 };
            for (int i = 0; i < numbers.Length; i++) {
                Assert.AreEqual(results[i], (MathClass.Abs(results[i])));
            }
        }

        [TestMethod()]
        public void InfixToPostfixTest()
        {
            string[] simpleExpressions = { "1+1", "1.2+3.4", "123*e+65", "(2-3)e*2", "12+34*56", "(1+2)*3", "123456789*2+4/2", "3*(1*2)+4-5","2+2^3","3+3!","4/2*3","1(2+2)" };
            string[] simpleResults = { "1 1 +", "1.2 3.4 +", "123 e * 65 +", "2 3 - e * 2 *", "12 34 56 * +", "1 2 + 3 *", "123456789 2 * 4 2 / +", "3 1 2 * * 4 + 5 -","2 2 3 ^ +","3 3 ! +","4 2 / 3 *","1 2 2 + *"};
            for (int i = 0; i < simpleExpressions.Length; i++) {
                Assert.AreEqual(simpleResults[i], MathClass.InfixToPostfix(simpleExpressions[i]));
            }

            string[] expressionsWithNegativeNums = { "-5","2-3+4","(2*3)-2","3*-5","4/2*-3" };
            string[] resultsForNegatives = { "0 5 -", "2 3 4 + -", "2 3 * 2 -", "3 0 5 - *","4 2 / 0 3 - *" };
            for (int i = 0; i < expressionsWithNegativeNums.Length; i++) {
                Assert.AreEqual(resultsForNegatives[i], MathClass.InfixToPostfix(expressionsWithNegativeNums[i]));
            }

            string[] funcsExpressions = { "Abs(5)-3", "Abs(5-3)", "Abs(3*(2-4))", "Abs(((2+2)*(3+1))*(3-6))", "Log(20)","Root((60+4),2)" };
            string[] funcsResults = { "5 A 3 -", "5 3 - A", "3 2 4 - * A", "2 2 + 3 1 + * 3 6 - * A", "20 L", "60 4 + 2 R" };
            for (int i = 0; i < funcsExpressions.Length; i++) {
                Assert.AreEqual(funcsResults[i], MathClass.InfixToPostfix(funcsExpressions[i]));
            } 
        }

        [TestMethod()]
        public void FromStringTest()
        {
            string[] expressions = { "1+1","12-4","3*2","5/2","2+3*4","3/4+2+3*4","(2+3)*4", "2π*3+4", "2+3^3","3*3!","1-4*2","3*-5","-4+2*3",
                                     "-20*4+80/2", "4/2*-3","3*4/3","3(1+1)","2(4*2)+6","Abs(-10)","Abs(10-3(2*3))","Log(100*100)","Root(64,2)", "Root(25*5,1+2)","3Log(10)" };
            double[] results = { 2, 8, 6, 2.5, 14, 14.75, 20 , 6*System.Math.PI + 4, 29, 18,-7,-15, 2,-40,-6,4,6,22,10,8,4,8,5,3 };
            for (int i = 0; i < expressions.Length; i++) {
                Assert.AreEqual(results[i], MathClass.FromString(expressions[i]));
            }
            Assert.ThrowsException<FormatException>(() => MathClass.FromString("2(3*2"));
            Assert.ThrowsException<FormatException>(() => MathClass.FromString("1*/3"));
            Assert.ThrowsException<FormatException>(() => MathClass.FromString("AHOJ"));
        }
    }
}