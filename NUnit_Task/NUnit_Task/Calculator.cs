using System;
using System.Linq;

namespace NUnit_Task
{
    public class Calculator
    {
        public double AddNumbers(double[] array)
        {
            return array.Sum();
        }

        public double SubtractNumbers(double[] array)
        {
            double subtractResult = array.First();
            double s = array.First();
            for (int i = 1; i < array.Length; i++)
            {
                s -= array[i];
            }
            return subtractResult;
        }

        public double MultiplyNumbers(double[] array)
        {
            double multiplyResult = 1;
            foreach (double a in array)
            {
                multiplyResult *= a;
            }
            return multiplyResult;
        }

        public double DivideNumbers(double firstValue, double secondValue)
        {
            return firstValue / secondValue;
        }
    }
}
