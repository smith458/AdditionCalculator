using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionCalculator.Test.Exponent_Tests
{
    [TestFixture]
    public class When_power_one
    {
        [Test]
        public void Exponent_one_to_the_one()
        {
            var result = Calculator.Exponent(1, 1);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Exponent_large_to_the_one()
        {
            var result = Calculator.Exponent(1234, 1);
            Assert.AreEqual(1234, result);
        }

        [Test]
        public void Exponent_negative_to_the_one()
        {
            var result = Calculator.Exponent(-8, 1);
            Assert.AreEqual(-8, result);
        }

        [Test]
        public void Exponent_zero_to_the_one()
        {
            var result = Calculator.Exponent(0, 1);
            Assert.AreEqual(0, result);
        }
    }
}
