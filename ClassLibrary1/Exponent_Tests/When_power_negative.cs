using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionCalculator.Test.Exponent_Tests
{
    class When_power_negative
    {
        public class When_power_one
        {
            public void Exponent_one_to_the_negative()
            {
                Assert.Throws<ArgumentException>(delegate { Calculator.Exponent(1, -1); });
            }

            public void Exponent_large_to_the_negative()
            {
                Assert.Throws<ArgumentException>(delegate { Calculator.Exponent(3, -4); });
            }

            public void Exponent_negative_to_the_negative()
            {
                Assert.Throws<ArgumentException>(delegate { Calculator.Exponent(5, -3); });
            }

            public void Exponent_zero_to_the_negative()
            {
                var result = Calculator.Exponent(0, -2);
                Assert.AreEqual(0, result);
            }
        }
    }
}
