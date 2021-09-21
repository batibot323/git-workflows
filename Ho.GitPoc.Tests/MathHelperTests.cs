using Ho.GitPoc.ConsoleApp;
using System;
using Xunit;

namespace Ho.GitPoc.Tests
{
    public class MathHelperTests
    {
        [Fact]
        public void TestForLowEvenNumbers()
        {
            Assert.True(MathHelper.IsOddOrEven(2));
        }

        [Fact]
        public void TestForLowOddNumbers()
        {
            Assert.False(MathHelper.IsOddOrEven(1));
        }

        [Fact]
        public void TestForHighEvenNumbers()
        {
            Assert.True(MathHelper.IsEven(2048));
        }

        [Fact]
        public void TestForHighOddNumbers()
        {
            Assert.True(MathHelper.IsEven(2049));
        }
    }
}
