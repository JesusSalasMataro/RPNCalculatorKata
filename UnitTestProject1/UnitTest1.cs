using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPNCalculatorKata;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void When_A_Digit_Is_Sent_Output_Digit()
        {
            // ARRANGE
            string input = "1";
            RPNCalculator calculator = new RPNCalculator();

            // ACT
            string actualResult = calculator.Evaluate(input);
            string expectedResult = "1";

            // ASSERT
            Assert.IsTrue(expectedResult.Equals(actualResult));
        }

        [TestMethod]
        public void When_Some_Digits_Are_Sent_Output_Number()
        {
            // ARRANGE
            string input = "12 3";
            RPNCalculator calculator = new RPNCalculator();

            // ACT
            string actualResult = calculator.Evaluate(input);
            string expectedResult = "12 3";

            // ASSERT
            Assert.IsTrue(expectedResult.Equals(actualResult));
        }

        [TestMethod]
        public void When_An_Operator_Is_Sent_After_Two_Numbers_Calculate_Result()
        {
            // ARRANGE
            string input = "12 3 +";
            RPNCalculator calculator = new RPNCalculator();

            // ACT
            string actualResult = calculator.Evaluate(input);
            string expectedResult = "15";

            // ASSERT
            Assert.IsTrue(expectedResult.Equals(actualResult));
        }

        [TestMethod]
        public void When_An_Operator_Is_Sent_After_Two_Numbers_Calculate_Result_Several_Operators_Case()
        {
            // ARRANGE
            string input = "6 3 + 5 -";
            RPNCalculator calculator = new RPNCalculator();

            // ACT
            string actualResult = calculator.Evaluate(input);
            string expectedResult = "4";

            // ASSERT
            Assert.IsTrue(expectedResult.Equals(actualResult));
        }

        [TestMethod]
        public void Many_Operands_And_Operators_Case()
        {
            // ARRANGE
            string input = "3 5 8 * 7 + *";
            RPNCalculator calculator = new RPNCalculator();

            // ACT
            string actualResult = calculator.Evaluate(input);
            string expectedResult = "141";
            
            // ASSERT            
            Assert.IsTrue(expectedResult.Equals(actualResult));
        }

        [TestMethod]
        public void Operation_And_Two_Number_Combination_At_The_End_Case()
        {
            // ARRANGE
            string input = "7 2 - 3 4";
            RPNCalculator calculator = new RPNCalculator();

            // ACT
            string actualResult = calculator.Evaluate(input);
            string expectedResult = "5 3 4";

            // ASSERT
            Assert.IsTrue(expectedResult.Equals(actualResult));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Division_By_Zero_Exception_Case()
        {
            // ARRANGE
            string input = "7 2 - 0 /";
            RPNCalculator calculator = new RPNCalculator();

            // ACT
            string actualResult = calculator.Evaluate(input);

            // ASSERT
        }
    }
}
