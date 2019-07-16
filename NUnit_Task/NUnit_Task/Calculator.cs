using System;
namespace NUnit_Task
{
    public class Calculator
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }

        public Calculator()
        {
            Random rnd = new Random();
            FirstNumber = rnd.NextDouble();
            SecondNumber = rnd.NextDouble();
        }

        public Calculator(double firstNumber, double seconedNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = seconedNumber;
        }

        public double AddNumbers()
        {
            return FirstNumber + SecondNumber;
        }

        public double SubtractNumbers()
        {
            return FirstNumber - SecondNumber;
        }

        public double MultiplyNumbers()
        {
            return FirstNumber * SecondNumber;
        }

        public double DivideNumbers()
        {
            return FirstNumber / SecondNumber;
        }
    }
}
