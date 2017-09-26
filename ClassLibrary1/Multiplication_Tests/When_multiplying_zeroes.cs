using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionCalculator.Test.Multiplication_Tests
{
    public class When_multiplying_zeroes
    {
        [Test]
        public void Multiplying_zero_and_a_positive_number()
        {
            var result = Calculator.Multiply(0, 6);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Multiplying_zero_and_a_negative_number()
        {
            var result = Calculator.Multiply(0, -6);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Multiplying_a_positive_number_and_zero()
        {
            var result = Calculator.Multiply(3, 0);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Multiplying_a_negative_number_and_zero()
        {
            var result = Calculator.Multiply(-1, 0);
            Assert.AreEqual(0, result);
        }
    }
}
