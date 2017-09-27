using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionCalculator.Test.Exponent_Tests
{
    public class When_power_zero
    {
        public void Exponent_one_to_the_zero()
        {
            var result = Calculator.Exponent(1, 0);
            Assert.AreEqual(1, result);
        }

        public void Exponent_positive_to_the_zero()
        {
            var result = Calculator.Exponent(11, 0);
            Assert.AreEqual(1, result);
        }

        public void Exponent_negative_to_the_zero()
        {
            var result = Calculator.Exponent(-15, 0);
            Assert.AreEqual(1, result);
        }

        public void Exponent_zero_to_the_zero()
        {
            var result = Calculator.Exponent(0, 0);
            Assert.AreEqual(0, result);
        }
    }
}
