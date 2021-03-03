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
            public void AdditionTest()
            {
                double result = MathClass.Add(num1, num2);
                double expected = 12;
                Assert.AreEqual(result, expected);
            }
            [TestMethod()]
            public void SubtractionTest()
            {
                double result = MathClass.Subtract(num2, num1);
                double expected = 4;
                Assert.AreEqual(result, expected);
            }
            [TestMethod()]
            public void DivisionTest() 
            {
                double result = MathClass.Divide(num2, num1);
                double expected = 2;
                Assert.AreEqual(result, expected);
                Assert.ThrowsException<ArithmeticException>(() => MathClass.Divide(num1, 0));
            }
        }
}