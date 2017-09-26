using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionCalculator.Test.Division_Tests
{
    [TestFixture]
    public class When_dividing_positive_integer
    {
        [Test]
        public void Dividing_one_by_one()
        {
            var results = Calculator.Divide(1, 1);
            Assert.AreEqual(1, results);
        }

        [Test]
        public void Dividing_positive_integer()
        {
            var results = Calculator.Divide(4, 2);
            Assert.AreEqual(2, results);
        }

        [Test]
        public void Dividing_large_positive_integer()
        {
            var results = Calculator.Divide(10000, 100);
            Assert.AreEqual(100, results);
        }
    }
}
