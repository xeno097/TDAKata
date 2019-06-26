using NumberInWords;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NumberInwordsTests
{
    [TestFixture]
    public class NumInwordsTests
    {
        [Test]
        public void With1_returns_onedollar()
        {
            VConverter vConverter = new VConverter();
            Assert.AreEqual("one dollar", vConverter.NumToString(1));
        }

        [Test]
        public void With15_returns_fifteendollars()
        {
            VConverter vConverter = new VConverter();
            Assert.AreEqual("fifteen dollars", vConverter.NumToString(15));
        }

        [Test]
        public void With23_returns_twentythreedollars()
        {
            VConverter vConverter = new VConverter();
            Assert.AreEqual("twenty three dollars", vConverter.NumToString(23));
        }

        [Test]
        public void With57_returns_fiftysevendollars()
        {
            VConverter vConverter = new VConverter();
            Assert.AreEqual("fifty seven dollars", vConverter.NumToString(57));
        }

        [Test]
        public void With257_returns_twohundredfiftysevendollars()
        {
            VConverter vConverter = new VConverter();
            Assert.AreEqual("two hundred fifty seven dollars", vConverter.NumToString(257));
        }

        [Test]
        public void With9999_returns_ninethousandninehundredninetyninedollars()
        {
            VConverter vConverter = new VConverter();
            Assert.AreEqual("nine thousand nine hundred ninety nine dollars", vConverter.NumToString(9999));
        }

    }
}
