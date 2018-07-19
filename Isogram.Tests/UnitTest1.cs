using System;
using Xunit;
using Isogram;

namespace Isogram.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Fact1()
        {
            Assert.True(IsogramClass.IsogramMethod(""));
        }
        [Fact]
        public void Fact2()
        {
            Assert.True(IsogramClass.IsogramMethod("isogram"));
        }
        [Fact]
        public void Fact3()
        {
            Assert.False(IsogramClass.IsogramMethod("eleven"));
        }
        [Fact]
        public void Fact4()
        {
            Assert.True(IsogramClass.IsogramMethod("subdermatoglyphic"));
        }
        [Fact]
        public void Fact5()
        {
            Assert.True(IsogramClass.IsogramMethod("Alphabet"));
        }
        [Fact]
        public void Fact6()
        {
            Assert.True(IsogramClass.IsogramMethod("thumbscrew-japingly"));
        }
        [Fact]
        public void Fact7()
        {
            Assert.True(IsogramClass.IsogramMethod("six-year-old"));
        }
        [Fact]
        public void Fact8()
        {
            Assert.False(IsogramClass.IsogramMethod("sai kiran"));
        }

    }
}
