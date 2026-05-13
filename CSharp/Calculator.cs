using System;

namespace Lab
{
    public class ExpressionCalculator
    {
        private double _a;
        private double _c;
        private double _d;

        public double A { get => _a; set => _a = value; }
        public double C { get => _c; set => _c = value; }
        public double D { get => _d; set => _d = value; }

        public ExpressionCalculator(double a, double c, double d)
        {
            _a = a;
            _c = c;
            _d = d;
        }

        public double CalculateLogarithm(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("arg should be > 0.");
            }
            if (Math.Abs(value - 1) < 1e-9)
            {
                throw new DivideByZeroException("denominator = 0, (ln(1) = 0).");
            }
            return Math.Log(value);
        }

        public double CalculateFullExpression()
        {
            double numerator = 2 * _c - _d / 23.0;
            double logArgument = 1 - _a / 4.0;

            double denominator = CalculateLogarithm(logArgument);

            return numerator / denominator;
        }
    }
}