using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionCalculator.Test.Division_Tests
{
    class When_dividing_zero
    {
        [Test]
        public void Dividing_zero_by_positive_integer()
        {
            var result = Calculator.Divide(0, 1);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Dividing_positve_nonmultiple_by_negative_integer()
        {
            var result = Calculator.Divide(0, -1);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Dividing_integer_by_zero()
        {
            Assert.Throws<DivideByZeroException>(delegate { Calculator.Divide(7, 0); });
        }
    }
}
