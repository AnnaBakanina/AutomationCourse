using NUnit.Framework;
using System;
namespace NUnit_Task
{
    //классическая модель/ доп. тест на сравнение что число находится в промежутке между один числом и другим/
    //анотации: _репит, _ретрай, _ордер, _категория, _игнор, _pairvise

    [TestFixture, Description("Tests fot Scientific CalculatorTests")]
    [Category("Scientific Calculator Tests")]

    public class ScientificCalculatorTests
    {
        private double startRange;
        private double endRange;
        private double firstNumber;
        private double secondNumber;
        private double percent;
        private double[] arrayToTest;
        ScientificCalculator ScientificCalculator;

        [SetUp]
        public void SetUp()
        {
            startRange = 9;
            endRange = 20;
            firstNumber = 12.47;
            secondNumber = 25.93;
            percent = 10;
            arrayToTest = new double[] { 2, 3.344, 4, 5.54, 6, 3.987 };
            ScientificCalculator = new ScientificCalculator();
        }

        [Test, Description("Test that value is in the range of two values"), Order(2)]
        public void CheckIfValueIsInTheRange()
        {
            bool comparisonResult = firstNumber > startRange && firstNumber < endRange;

            Assert.AreEqual(comparisonResult, true,
                $"{firstNumber} is in the range from {startRange} to {endRange}");
        }

        [Test, Pairwise, Order(2)]
        public void PairwiseTest(
            [Values("value1", "value2")] string initialValues,
            [Values("+", "-", "*")] string actions,
            [Values("value3")] string valuesToAdd
            )
        {
            Console.WriteLine($"{firstNumber},{secondNumber},{startRange}", initialValues, actions, valuesToAdd);
        }

        [Test, Description("Test pow option"), Repeat(1)]
        public void PowOption()
        {
            double powResult = ScientificCalculator.Pow(firstNumber, secondNumber);

            Assert.That(Math.Pow(firstNumber, Math.Abs(secondNumber)), Is.EqualTo(powResult),
                $"Check that {firstNumber}^{secondNumber} is equal to {Math.Pow(firstNumber, Math.Abs(secondNumber))}");
        }

        [Test, Description("Test percent option")]
        public void PercentOption()
        {
            double percentResult = ScientificCalculator.Percents(firstNumber, percent);

            Assert.That(firstNumber / 100 * percent, Is.EqualTo(percentResult),
                $"Check that {percent}% from {firstNumber} is equal to {firstNumber / 100 * percent}");
        }

        [Test, Description("Test mod option")]
        public void ModOption()
        {
            double modResult = ScientificCalculator.Mod(firstNumber, secondNumber);

            Assert.That(firstNumber % secondNumber, Is.EqualTo(modResult),
                $"Check that {firstNumber}%{secondNumber} is equal to {firstNumber % secondNumber}");
        }

        [Test, Description("Test find sum of array option")]
        public void ArraySumOption()
        {
            double sumOfValues = 0;
            double sumResult = ScientificCalculator.SumOfArrayValues(arrayToTest);

            foreach (double a in arrayToTest)
            {
                sumOfValues += a;
            }
            Assert.That(sumOfValues, Is.EqualTo(sumResult), "Check sum of array: false");
        }

        [Test, Description("Test find min of array option")]
        public void ArrayMinOption()
        {
            double minValue = double.MaxValue;
            double minResult = ScientificCalculator.MinValueOfArray(arrayToTest);

            foreach(double a in arrayToTest)
            {
                if (a<minValue)
                {
                    minValue = a;
                }
            }
            Assert.That(minValue, Is.EqualTo(minResult), "Check find min value of array: false");
        }

        [Test, Description("Test find max of array option"), Retry(2)]
        public void ArrayMaxOption()
        {
            double maxValue = double.MinValue;
            double maxResult = ScientificCalculator.MaxValueOfArray(arrayToTest);

            foreach (double a in arrayToTest)
            {
                if (a > maxValue)
                {
                    maxValue = a;
                }
            }
            Assert.That(maxValue, Is.EqualTo(maxResult), "Check find max value of array: false");
        }

        [TestCase(2,3, ExpectedResult = 5), Order(1)]
        [Ignore("No need to check anymore")]
        [TestCase(4,-6, ExpectedResult = -2)]
        [TestCase(2.4, 92, ExpectedResult = 90.4)]
        public double AddNumbers(double a, double b)
        {
            return a + b;
        }

    }
}