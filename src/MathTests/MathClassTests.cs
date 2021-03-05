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
        /// Tests for additon.
        /// </summary>
        /// <returns>Test passes when all results are equal to all the expectations otherwise fails.</returns>
        public void AdditionTestWithPositiveNumbers()
        {
            double[] firstNums = { 5, 8, 1, 12, 22, 1874, 14, 89345.568, 10048456, 45424141 };
            double[] secondNums = { 97, 45, 4, 48, 0, 1, 64, 15478.7452, 97711, 1124764545 };
            double[] results = { 102, 53, 5, 60, 22, 1875, 78, 104824.3132, 10146167, 1170188686 };
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
            Assert.ThrowsException<ArithmeticException>(() => MathClass.Divide(num1, 0));
            result = MathClass.Divide(-53, -5);
            expected = 10.6;
            Assert.AreEqual(result, expected);
        }
    }
}