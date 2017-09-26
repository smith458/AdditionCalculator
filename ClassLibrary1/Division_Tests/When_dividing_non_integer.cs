using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionCalculator.Test.Division_Tests
{
    class When_dividing_non_integer
    {
        [Test]
        public void Dividing_positive_nonmultiple_by_positive_integer()
        {
            Assert.Catch<ArgumentException>(delegate { Calculator.Divide(1, 2); });
        }

        [Test]
        public void Dividing_positive_nonmultiple_by_negative_integer()
        {
            Assert.Catch<ArgumentException>(delegate { Calculator.Divide(5, -2); });
        }

        [Test]
        public void Dividing_negative_nonmultiple_by_positive_integer()
        {
            Assert.Catch<ArgumentException>(delegate { Calculator.Divide(-10, 3); });
        }

        [Test]
        public void Dividing_negative_nonmultiple_by_negative_integer()
        {
            Assert.Catch<ArgumentException>(delegate { Calculator.Divide(-7, -2); });
        }
    }
}
