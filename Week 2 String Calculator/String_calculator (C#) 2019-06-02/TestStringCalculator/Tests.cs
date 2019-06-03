using NUnit.Framework;
using String_calculator;
using static String_calculator.Errors;

namespace TestStringCalculator
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void with123_returns6()
        {
            StringAdd stringadd = new StringAdd();

            Assert.AreEqual("6", stringadd.Add("1,2,3"));
        }

        [Test]
        public void withempty_returns0()
        {
            StringAdd stringadd = new StringAdd();

            Assert.AreEqual("0", stringadd.Add(""));
        }

        [Test]
        public void with123456_returns21()
        {
            StringAdd stringadd = new StringAdd();

            Assert.AreEqual("21", stringadd.Add("1,2,3,4,5,6"));
        }

        [Test]
        public void withmanynumbers_returnstheirsum()
        {
            StringAdd stringadd = new StringAdd();

            Assert.AreEqual("29", stringadd.Add("1,2,5,6,7,8"));
        }

        [Test]
        public void with1newline23_returns6()
        {
            StringAdd stringadd = new StringAdd();

            Assert.AreEqual("6", stringadd.Add("1\n2,3"));
        }

        [Test]
        public void with1newlinenewline_returnsError()
        {
            StringAdd stringadd = new StringAdd();

            Assert.Throws<InvalidValue>(delegate { stringadd.Add("1752,\n35"); });
        }


        [Test]
        public void withsepattheend_throwsexception()
        {
            StringAdd stringadd = new StringAdd();

            Assert.Throws<EOFException>(delegate { stringadd.Add("1,2,3,"); });
        }

        [Test]
        public void withnegative_throwsexception()
        {
            StringAdd stringadd = new StringAdd();

            Assert.Throws<NegativeNumber>(delegate { stringadd.Add("-1,2,3"); });
        }
    }
}
