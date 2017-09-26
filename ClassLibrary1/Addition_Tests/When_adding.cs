using NUnit.Framework;

namespace AdditionCalculator.Test.Addition_Tests
{
    [TestFixture]
    public class When_adding
    {
        [Test]
        public void Adding_two_ones()
        {
            var result = Calculator.Add(1,1);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Adding_two_large_numbers()
        {
            var result = Calculator.Add(10000, 100000);
            Assert.AreEqual(110000, result);
        }

        [Test]
        public void Adding_a_positive_one_and_negative_one()
        {
            var result = Calculator.Add(1, -1);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Adding_a_positive_number_and_a_negative_number()
        {
            var result = Calculator.Add(6, -10);
            Assert.AreEqual(-4, result);
        }

        [Test]
        public void Adding_two_negative_numbers()
        {
            var result = Calculator.Add(-5, -10);
            Assert.AreEqual(-15, result);
        }
    }
}
