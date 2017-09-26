using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AdditionCalculator.Test.Multiplication_Tests
{
    [TestFixture]
    public class When_multiplying_positives
    {
        [Test]
        public void Multiplying_one_and_one()
        {
            var result = Calculator.Multiply(1, 1);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Multiplying_two_large_numbers()
        {
            var result = Calculator.Multiply(1000, 1000);
            Assert.AreEqual(1000000, result);
        }
    }
}
