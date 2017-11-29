using System;
using NUnit.Framework;

namespace TestNUnit
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void CodEWaRs_2()
        {
            Assert.AreEqual(new int[] { 0, 3, 4, 6 }, CapitalLetter.Library.CapitalLetter.CountCapitals("CodEWaRs"));
        }
    }
}
