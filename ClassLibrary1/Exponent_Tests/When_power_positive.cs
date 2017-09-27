using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionCalculator.Test.Exponent_Tests
{
    public class When_power_positive
    {
        public void Exponent_one_to_the_positive()
        {
            var result = Calculator.Exponent(1, 17);
            Assert.AreEqual(1, result);
        }

        public void Exponent_positive_to_the_positive()
        {
            var result = Calculator.Exponent(9, 2);
            Assert.AreEqual(81, result);
        }

        public void Exponent_negative_to_the_positive()
        {
            var result = Calculator.Exponent(-5, 3);
            Assert.AreEqual(-125, result);
        }

        public void Exponent_zero_to_the_positive()
        {
            var result = Calculator.Exponent(0, 5);
            Assert.AreEqual(0, result);
        }
    }
}
