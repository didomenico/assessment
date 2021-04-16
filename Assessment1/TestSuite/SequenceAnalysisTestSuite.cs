using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Assessment1
{
    [TestClass]
    public class SequenceAnalysisTestSuite
    {     
        [TestMethod]
        public void TestEmpty()
        {
            Assert.AreEqual("", SequenceAnalysis.Order(""));
            Assert.AreEqual("", SequenceAnalysis.Order(null));
        }

        [TestMethod]
        public void TestLowerCase()
        {
            Assert.AreEqual("", SequenceAnalysis.Order("abc"));
            Assert.AreEqual("", SequenceAnalysis.Order("abc cba"));            
        }

        [TestMethod]
        public void TestUpperCase()
        {
            Assert.AreEqual("A", SequenceAnalysis.Order("A"));
        }

        [TestMethod]
        public void TestUpperLowerCaseTogether()
        {
            Assert.AreEqual("", SequenceAnalysis.Order("aBc CBa"));
            Assert.AreEqual("A", SequenceAnalysis.Order("dbc A"));
        }

        [TestMethod]
        public void TestNumbers()
        {
            Assert.AreEqual("ELMOR", SequenceAnalysis.Order("Words W1TH NUMB3RS D0N'T W0RK ipsem LOROEMO"));
        }
    }
}
