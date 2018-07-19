using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Isogram;

namespace Isogram.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, IsogramClass.IsogramMethod(""));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(true, IsogramClass.IsogramMethod("isogram"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(false, IsogramClass.IsogramMethod("eleven"));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(true, IsogramClass.IsogramMethod("subdermatoglyphic"));
        }
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(true, IsogramClass.IsogramMethod("Alphabet"));
        }
        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(true, IsogramClass.IsogramMethod("thumbscrew-japingly"));
        }
        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(true, IsogramClass.IsogramMethod("six-year-old"));
        }
        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual(false, IsogramClass.IsogramMethod("sai kiran"));
        }

    }
}
