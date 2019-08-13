using System;
using System.Linq;

namespace NUnit_Task
{
    public class ScientificCalculator:Calculator
    {
        public double Pow(double x, double y)
        {
            return Math.Pow(x, Math.Abs(y));
        }

        public double Percents(double number, double percent)
        {
            return number / 100 * percent;
        }

        public double Mod(double x, double y)
        {
            return Math.Abs(x) % Math.Abs(y);
        }

        public double SumOfArrayValues(double[] array)
        {
            return array.Sum();
        }

        public double MinValueOfArray(double[] array)
        {
            return array.Min();
        }

        public double MaxValueOfArray(double[] array)
        {
            return array.Max();
        }
    }
}
