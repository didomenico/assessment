using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Assessment1
{
    [TestClass]
    public class TestSuite
    {
        [TestMethod]
        public void TestSumOfMultiple()
        {
            Assert.AreEqual(0, SumOfMultiples.Until(0));

            Assert.AreEqual(0, SumOfMultiples.Until(15));
            Assert.AreEqual(15, SumOfMultiples.Until(16));

            Assert.AreEqual(15, SumOfMultiples.Until(30));
            Assert.AreEqual(45, SumOfMultiples.Until(31));

            Assert.AreEqual(45, SumOfMultiples.Until(45));
            Assert.AreEqual(90, SumOfMultiples.Until(46));
        }

        [TestMethod]
        public void TestSequenceAnalysis()
        {
            Assert.AreEqual("", SequenceAnalysis.Order(""));
            
            Assert.AreEqual("abc", SequenceAnalysis.Order(""));
            Assert.AreEqual("abc cba", SequenceAnalysis.Order(""));
            Assert.AreEqual("aBc CBa", SequenceAnalysis.Order(""));

            Assert.AreEqual("A", SequenceAnalysis.Order("A"));
            Assert.AreEqual("A", SequenceAnalysis.Order("dbc A"));

            Assert.AreEqual("ELMOR", SequenceAnalysis.Order("Words W1TH NUMB3RS D0N'T W0RK ipsem LOREM"));
        }
    }
}
