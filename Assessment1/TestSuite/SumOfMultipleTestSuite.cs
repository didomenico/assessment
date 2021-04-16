using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Assessment1
{
    [TestClass]
    public class SumOfMultipleTestSuite
    {
        [TestMethod]
        public void TestZero()
        {
            Assert.AreEqual(0, SumOfMultiples.Until(0));
        }

        [TestMethod]
        public void TestBottomLimit()
        {
            Assert.AreEqual(15, SumOfMultiples.Until(16));
            Assert.AreEqual(45, SumOfMultiples.Until(31));
            Assert.AreEqual(90, SumOfMultiples.Until(46));
        }

        [TestMethod]
        public void TestTopLimit()
        {
            Assert.AreEqual(15, SumOfMultiples.Until(30));
            Assert.AreEqual(45, SumOfMultiples.Until(45));
        }
    }
}
