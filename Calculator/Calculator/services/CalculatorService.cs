using System;

namespace Calculator.Services
{
    public class CalculatorService
    {
        public double Cong(double a, double b) => a + b;

        public double Tru(double a, double b) => a - b;

        public double Nhan(double a, double b) => a * b;

        public double Chia(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Không thể chia cho 0");

            return a / b;
        }
    }
}