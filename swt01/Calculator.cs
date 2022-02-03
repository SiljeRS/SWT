using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Calculator
    {
        private double _result;
        priavte 

        public double Add(double a, double b)
        {
            _result = a + b;
            return _result;
        }

        public double Subtract(double a, double b)
        {
            return _result = a - b;
        }

        public double Multiply(double a, double b)
        {
            return _result = a * b;
        }

        public double Power(double x, double exp)
        {
            return _result = Math.Pow(x, exp);
        }

        public double Accumulator 
        {
            get => _result;
            private set => _result = value;
        }
        public int MyProperty { get; private set; }
        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
                return 0;
            return dividend / divisor;
        }
    }
}
