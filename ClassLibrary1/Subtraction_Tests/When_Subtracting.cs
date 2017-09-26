using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionCalculator.Test.Subtraction_Tests
{
    [TestFixture]
    public class When_subtracting
    {
        [Test]
        public void Subtracting_one_from_one()
        {
            var result = Calculator.Subtract(1, 1);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Subtracting_large_number_from_one()
        {
            var result = Calculator.Subtract(1, 1000);
            Assert.AreEqual(-999, result);
        }

        [Test]
        public void Subtracting_negative_number_from_positive_number()
        {
            var result = Calculator.Subtract(15, -20);
            Assert.AreEqual(35, result);
        }

        [Test]
        public void Subtracting_positive_number_from_negative_number()
        {
            var result = Calculator.Subtract(-3, 5);
            Assert.AreEqual(-8, result);
        }

        [Test]
        public void Subtracting_negative_number_from_negative_number()
        {
            var result = Calculator.Subtract(-5, -11);
            Assert.AreEqual(6, result);
        }
    }
}
