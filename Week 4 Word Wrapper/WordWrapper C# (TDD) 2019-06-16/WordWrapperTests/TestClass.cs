using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using WordWrapper;

namespace WordWrapperTests
{
    [TestFixture]
    class TestClass
    {
        [Test]
        public void WithEmptyString_ReturnsEmpty()
        {
            Wrapper wrapper = new Wrapper("", 10);
            Assert.That(wrapper.Wrap() == "");
        }

        [Test]
        public void WithSunAndMoon_ReturnsSunNewLineMoon()
        {
            Wrapper wrapper = new Wrapper("Sun Moon", 4);
            Assert.That(wrapper.Wrap() == "Sun \nMoon\n");
        }

        [Test]
        public void WithSomeWordsAndMaxlen5_Returns_EveryWordOnADifferentLine()
        {
            Wrapper wrapper = new Wrapper("Sun Moon Earth", 5);
            Assert.That(wrapper.Wrap() == "Sun  \nMoon \nEarth\n");
        }

        [Test]
        public void WithOneWordLArgerThanMaxLen_Throws_NotWrappableWordsException()
        {
            Wrapper wrapper = new Wrapper("Moon", 3);
            Assert.Throws<NotWrappableWordsException>(delegate {wrapper.Wrap(); });
        }

    }
}
