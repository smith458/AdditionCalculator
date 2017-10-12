using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionCalculator.Test.Exponent_Tests
{
    [TestFixture]
    public class When_power_negative
    {
        [Test]
        public void Exponent_one_to_the_negative()
        {
            Assert.Throws<ArgumentException>(delegate { Calculator.Exponent(1, -1); });
        }

        [Test]
        public void Exponent_large_to_the_negative()
        {
            Assert.Throws<ArgumentException>(delegate { Calculator.Exponent(3, -4); });
        }

        [Test]
        public void Exponent_negative_to_the_negative()
        {
            Assert.Throws<ArgumentException>(delegate { Calculator.Exponent(5, -3); });
        }

        [Test]
        public void Exponent_zero_to_the_negative()
        {
            Assert.Throws<ArgumentException>(delegate { Calculator.Exponent(0, -2); });
        }
    }
}
