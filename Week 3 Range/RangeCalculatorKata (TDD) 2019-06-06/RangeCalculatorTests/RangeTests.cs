using NUnit.Framework;
using RangeCalculatorKata;

namespace RangeCalculatorTests
{
    [TestFixture]
    class RangeTests
    {
        [Test]
        public void WithLow2andHigh6_contains4_ReturnTrue()
        {
            RangeCalculator rangeCalculator = new RangeCalculator("[2,6)");
            Assert.AreEqual(rangeCalculator.Range("{4}"),true);
        }

        [Test]
        public void WithLow2andHigh6_containsList_ReturnFalse()
        {
            RangeCalculator rangeCalculator = new RangeCalculator("[2,6)");
            Assert.AreEqual(rangeCalculator.Range("{-1,1,6,10}"), false);
        }

        [Test]
        public void WithLow2andHigh6_getAllPints_Returns2345()
        {
            RangeCalculator rangeCalculator = new RangeCalculator("[2,6)");
            Assert.AreEqual(rangeCalculator.GetAllPoints(), "{2,3,4,5}");
        }

        [Test]
        public void WithLow2andHigh5_contains_Range710()
        {
            RangeCalculator rangeCalculator = new RangeCalculator("[2,6)");
            Assert.AreEqual(rangeCalculator.Contains("[7,10)"), false);
        }

        [Test]
        public void WithLow2andHigh5_returns25()
        {
            RangeCalculator rangeCalculator = new RangeCalculator("[2,6)");
            Assert.AreEqual(rangeCalculator.EndPoints(), "{2,5}");
        }

        [Test]
        public void WithLow2andHigh4_doesNotOverlaps_low7high10()
        {
            RangeCalculator rangeCalculator = new RangeCalculator("[2,5)");
            Assert.AreEqual(rangeCalculator.OverLaps("[7,10)"), false);
        }

        [Test]
        public void WithLow3andHigh5_areequals_low3high5()
        {
            RangeCalculator rangeCalculator = new RangeCalculator("[3,5)");
            Assert.AreEqual(rangeCalculator.AreEquals("[3,5)"), true);
        }

    }
}
