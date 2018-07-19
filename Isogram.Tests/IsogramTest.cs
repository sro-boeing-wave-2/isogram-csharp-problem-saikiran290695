using System;
using Xunit;
using Isogram;

namespace Isogram.Tests
{
    public class IsogramTest
    {
        [Fact]
        public void TestMethod1()
        {
            Assert.True( IsogramClass.IsogramMethod(""));
        }
        [Fact]
        public void TestMethod2()
        {
            Assert.True( IsogramClass.IsogramMethod("isogram"));
        }
        [Fact]
        public void TestMethod3()
        {
            Assert.False( IsogramClass.IsogramMethod("eleven"));
        }
        [Fact]
        public void TestMethod4()
        {
            Assert.True(IsogramClass.IsogramMethod("subdermatoglyphic"));
        }
        [Fact]
        public void TestMethod5()
        {
            Assert.True( IsogramClass.IsogramMethod("Alphabet"));
        }
        [Fact]
        public void TestMethod6()
        {
            Assert.True( IsogramClass.IsogramMethod("thumbscrew-japingly"));
        }
        [Fact]
        public void TestMethod7()
        {
            Assert.True( IsogramClass.IsogramMethod("six-year-old"));
        }
        [Fact]
        public void TestMethod8()
        {
            Assert.False( IsogramClass.IsogramMethod("sai kiran"));
        }

    }
}
