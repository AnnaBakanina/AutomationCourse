using System;
using System.Linq;
using NUnit.Framework;

namespace NUnit_Task
{
    [TestFixture, Description("Tests for Calculator")]
    [Category("Calculator Tests")]
    public class CalculatorTests
    {
        double firstNumber;
        double secondNumber;
        private double[] arrayToTest;
        Calculator Calculator;

        [SetUp]
        public void SetUp()
        {
            firstNumber = 12;
            secondNumber = 17;
            arrayToTest = new double[] { 1, 3, 4, 5, 5 };
            Calculator = new Calculator();
        }

        [Test, Description("Check add operation")]
        public void CheckAdding()
        {
            double additionResult = Calculator.AddNumbers(arrayToTest);

            Assert.That(arrayToTest.Sum(), Is.EqualTo(additionResult),
                $"Check that sum of numbers is equal to '{arrayToTest.Aggregate((x, y) => x + y)}'.");
        }

        [Test, Description("Check subtract operation")]
        public void CheckSubtraction()
        {
            double substractionResult = Calculator.SubtractNumbers(arrayToTest);
            double calculationResult = arrayToTest.Aggregate((x, y) => x - y);

            Assert.That(calculationResult, Is.EqualTo(substractionResult),
                $"Check that {arrayToTest.ToString()} is equal to '{calculationResult}'.") ;
        }

        [Test, Description("Check devition operation")]
        public void CheckDevition()
        {
            double divitionResult = Calculator.DivideNumbers(firstNumber, secondNumber);
            double calculationResult = firstNumber / secondNumber;

            Assert.That(secondNumber, Is.Not.EqualTo(0), "Divition on 0 can't be performed");
            Assert.That(calculationResult, Is.EqualTo(divitionResult),
                $"Check that {firstNumber}/{secondNumber} is equal to '{calculationResult}'.");
        }

        [Test, Description("Check multiplying operation")]
        public void CheckMultiply()
        {
            double multiplyingResult = Calculator.MultiplyNumbers(arrayToTest);
            double calculationResult = arrayToTest.Aggregate((x, y) => x * y);

            Assert.That(calculationResult, Is.EqualTo(multiplyingResult),
                $"Check that {arrayToTest.ToString()} is equal to '{calculationResult}'.");
        }

        [TearDown]
        public void TearDown()
        {
            ToConsole("Tests end");
        }

        public static void ToConsole(string str)
        {
            System.Diagnostics.Debug.WriteLine(str);
        }
    }
}
