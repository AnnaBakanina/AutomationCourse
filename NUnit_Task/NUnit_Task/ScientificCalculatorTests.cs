using NUnit.Framework;
using System;
namespace NUnit_Task
{
    [TestFixture, Description("Tests fot Scientific CalculatorTests")]
    public class ScientificCalculatorTests
    {
        [Test, Description("Test pow option")]
        public void PowOption()
        {
            double numberOne = 10.234;
            double numberTwo = 3.543;

            ScientificCalculator obj = new ScientificCalculator();
            double powResult = obj.Pow(numberOne, numberTwo);

            Assert.That(Math.Pow(numberOne, Math.Abs(numberTwo)), Is.EqualTo(powResult), "Check pow option: false");
        }

        [Test, Description("Test percent option")]
        public void PercentOption()
        {
            double numberOne = 10.234;
            double numberTwo = 15.543;

            ScientificCalculator obj = new ScientificCalculator();
            double percentResult = obj.Percents(numberOne, numberTwo);

            Assert.That(numberOne / 100 * numberTwo, Is.EqualTo(percentResult), "Check percent option: false");
        }

        [Test, Description("Test mod option")]
        public void ModOption()
        {
            double numberOne = 10.234;
            double numberTwo = 15.543;

            ScientificCalculator obj = new ScientificCalculator();
            double modResult = obj.Mod(numberOne, numberTwo);

            Assert.That(numberOne % numberTwo, Is.EqualTo(modResult), "Check mod option: false");
        }

        [Test, Description("Test find sum of array option")]
        public void ArraySumOption()
        {
            double sumOfValues = 0.0;
            double[] array = { 2.456, 3, 6.4875, 3, 4.484, 5 };

            ScientificCalculator obj = new ScientificCalculator();
            double sumResult = obj.SumOfArrayValues(array);

            foreach (double a in array)
            {
                sumOfValues += a;
            }
            Assert.That(sumOfValues, Is.EqualTo(sumResult), "Check sum of array: false");
        }

        [Test, Description("Test find min of array option")]
        public void ArrayMinOption()
        {
            double minValue = double.MaxValue;
            double[] array = { 2.456, 3, 6.4875, 3, 4.484, 5 };

            ScientificCalculator obj = new ScientificCalculator();
            double minResult = obj.MinValueOfArray(array);

            foreach(double a in array)
            {
                if (a<minValue)
                {
                    minValue = a;
                }
            }
            Assert.That(minValue, Is.EqualTo(minResult), "Check find min value of array: false");
        }

        [Test, Description("Test find max of array option")]
        public void ArrayMaxOption()
        {
            double maxValue = double.MinValue;
            double[] array = { 2.456, 3, 6.4875, 3, 4.484, 5 };

            ScientificCalculator obj = new ScientificCalculator();
            double maxResult = obj.MaxValueOfArray(array);

            foreach (double a in array)
            {
                if (a > maxValue)
                {
                    maxValue = a;
                }
            }
            Assert.That(maxValue, Is.EqualTo(maxResult), "Check find max value of array: false");
        }
    }
}
