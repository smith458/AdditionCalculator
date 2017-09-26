using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionCalculator.Test.Division_Tests
{
    class When_dividing_negative_integer
    {
        [Test]
        public void Dividing_one_by_negative_one()
        {
            var results = Calculator.Divide(1, -1);
            Assert.AreEqual(-1, results);
        }

        [Test]
        public void Dividing_negative_one_by_one()
        {
            var results = Calculator.Divide(-1, 1);
            Assert.AreEqual(-1, results);
        }

        [Test]
        public void Dividing_positive_integer_by_negative_integer()
        {
            var results = Calculator.Divide(4, -2);
            Assert.AreEqual(-2, results);
        }

        [Test]
        public void Dividing_negative_integer_by_positive_integer()
        {
            var results = Calculator.Divide(-9, 3);
            Assert.AreEqual(-3, results);
        }

        [Test]
        public void Dividing_negative_integer_by_negative_integer()
        {
            var results = Calculator.Divide(-10, -2);
            Assert.AreEqual(5, results);
        }
    }
}
