using System;
using NUnit.Framework;

namespace NUnit_Task
{
    [TestFixture, Description("Tests for Calculator")]
    public class CalculatorTests
    {
        [SetUp]
        public void SetUp()
        {
            System.Diagnostics.Debug.WriteLine("Start tests");
        }

        [Test, Description("Check add operation")]
        public void CheckAdding()
        {
            Calculator numbers = new Calculator();
            double additionResult = numbers.AddNumbers();
            
            Assert.That(numbers.FirstNumber + numbers.SecondNumber, Is.EqualTo(additionResult), "Adding numbers test: False");
        }

        [Test, Description("Check subtract operation")]
        public void CheckSubtraction()
        {
            Calculator numbers = new Calculator();
            double substractionResult = numbers.SubtractNumbers();

            Assert.That(numbers.FirstNumber - numbers.SecondNumber, Is.EqualTo(substractionResult), "Subtrac numbers test: False");
        }

        [Test, Description("Check devition operation")]
        public void CheckDevition()
        {
            Calculator numbers = new Calculator();
            double divitionResult = numbers.DivideNumbers();

            Assert.That(numbers.SecondNumber, Is.Not.EqualTo(0), "Divition on 0 can't be performed");
            Assert.That(numbers.FirstNumber / numbers.SecondNumber, Is.EqualTo(divitionResult), "Divition numbers test: False");
        }

        [Test, Description("Check multiplying operation")]
        public void CheckMultiply()
        {
            Calculator numbers = new Calculator();
            double multiplyingResult = numbers.MultiplyNumbers();

            Assert.That(numbers.FirstNumber * numbers.SecondNumber, Is.EqualTo(multiplyingResult), "Multiply numbers test: False");
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
