using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StandardDeviation;

namespace StandardDeviationTests
{
    [TestClass]
    public class StandardDeviationClassTests
    {
        [TestMethod]
        public void ParseInputTest()
        {
            //Testing basic parsing
            string input = "1 2 3 4 5 6 7 8 9 10 ";
            double[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            CollectionAssert.AreEqual(expected, StandardDeviationClass.GetNumbersFromString(input));
            input = "455.564 -26.4871345 -0.974 410001.05 -248764.145 ";
            double[] expected2 = { 455.564, -26.4871345, -0.974, 410001.05, -248764.145 };
            CollectionAssert.AreEqual(expected2, StandardDeviationClass.GetNumbersFromString(input));

            //Testing field separators
            input = "1\t2\t3\t4\t5\t6\t7\t8\t9\t10 ";
            CollectionAssert.AreEqual(expected, StandardDeviationClass.GetNumbersFromString(input));
            input = "1\n2\n3\n4\n5\n6\n7\n8\n9\n10 ";
            CollectionAssert.AreEqual(expected, StandardDeviationClass.GetNumbersFromString(input));
            input = "1\t2\n3 4\n5\t6 7 8\n9\t10 ";
            CollectionAssert.AreEqual(expected, StandardDeviationClass.GetNumbersFromString(input));

            //Testing exceptions
            input = "asd asd ";
            Assert.ThrowsException<FormatException>(() => StandardDeviationClass.GetNumbersFromString(input));
            input = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ";
            Assert.ThrowsException<FormatException>(() => StandardDeviationClass.GetNumbersFromString(input));
            input = " ";
            Assert.ThrowsException<FormatException>(() => StandardDeviationClass.GetNumbersFromString(input));
        }

        [TestMethod]
        public void CountDeviationTest()
        {
            double[] basicInput = { 25.062, -97.542, 129.8721, 17546.4523, -500.07, -780.45 };
            double expected = 7271.254131903278;

            Assert.AreEqual(expected, StandardDeviationClass.CountStandardDeviation(basicInput));

            double[] inputs = new double[1000];
            double cnt = 1;
            for (int i = 0; i < inputs.Length; i++) inputs[i] = cnt++;
            expected = 288.81943609574938;
            Assert.AreEqual(expected, StandardDeviationClass.CountStandardDeviation(inputs));

            double[] inputs2 = new double[10000];
            cnt = -5568.458;
            for (int i = 0; i < inputs2.Length; i++) {
                inputs2[i] = cnt + cnt / 7;
                cnt++;
            }

            expected = 3299.309348465316;
            Assert.AreEqual(expected, StandardDeviationClass.CountStandardDeviation(inputs2));

            double[] onlyOneInput = new double[1];
            onlyOneInput[0] = -2445.56756;
            Assert.ThrowsException<DivideByZeroException>(() =>
            StandardDeviationClass.CountStandardDeviation(onlyOneInput));
        }

        [TestMethod]
        public void CountDeviationUsingFromStringTest()
        {
            double[] basicInput = { 25.062, -97.542, 129.8721, 17546.4523, -500.07, -780.45 };
            double expected = 7271.254131903279;

            Assert.AreEqual(expected, StandardDeviationClass.CountStandardDeviationUsingFromString(basicInput));

            double[] inputs = new double[100];
            double cnt = 1;
            for (int i = 0; i < inputs.Length; i++) inputs[i] = cnt++;
            expected = 29.01149197588202;
            Assert.AreEqual(expected, StandardDeviationClass.CountStandardDeviationUsingFromString(inputs));
            double[] inputs2 = new double[1000];
            cnt = -5568.458;
            for (int i = 0; i < inputs2.Length; i++) {
                inputs2[i] = cnt + cnt / 7;
                cnt++;
            }

            expected = 330.07935553812905;
            Assert.AreEqual(expected, StandardDeviationClass.CountStandardDeviationUsingFromString(inputs2));

            double[] onlyOneInput = new double[1];
            onlyOneInput[0] = -2445.56756;
            Assert.ThrowsException<DivideByZeroException>(() =>
            StandardDeviationClass.CountStandardDeviationUsingFromString(onlyOneInput));

        }
    }
}