using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapitalLetter.Test
{
    [TestClass]
    public class CapitalLetterUnitTest
    {


        [TestMethod]
        public void CodEWaRs()
        {
            Assert.AreEqual(new int[] { 0, 3, 4, 6 }, CapitalLetter.Library.CapitalLetter.CountCapitals("CodEWaRs"));
        }

        [TestMethod]
        public void NoneOrEmpty()
        {
            Assert.AreEqual(new int[] { }, CapitalLetter.Library.CapitalLetter.CountCapitals("none"));
            Assert.AreEqual(new int[] { }, CapitalLetter.Library.CapitalLetter.CountCapitals(""));
        }

        [TestMethod]
        public void TestOther()
        {
            Assert.AreEqual(new int[] { 0, 1, 2, 3, 4, 5 }, CapitalLetter.Library.CapitalLetter.CountCapitals("ALLALL"));
            Assert.AreEqual(new int[] { 0 }, CapitalLetter.Library.CapitalLetter.CountCapitals("Kata"));
        }
    }
}
