using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionCalculator.Test.Multiplication_Tests
{
    public class When_multiplying_negatives
    {
        [Test]
        public void Multiplying_a_positive_number_and_a_negative_number()
        {
            var result = Calculator.Multiply(5, -3);
            Assert.AreEqual(-15, result);
        }

        [Test]
        public void Multiplying_two_negative_numbers()
        {
            var result = Calculator.Multiply(-4, -6);
            Assert.AreEqual(24, result);
        }
    }
}
