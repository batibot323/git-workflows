using Ho.GitPoc.ConsoleApp;
using System;
using Xunit;

namespace Ho.GitPoc.Tests
{
    public class MathHelperTests
    {
        [Fact]
        public void TestForEvenLowEvenNumbers()
        {
            Assert.True(MathHelper.IsOddOrEven(2));
        }

        [Fact]
        public void TestForOddLowEvenNumbers()
        {
            Assert.False(MathHelper.IsOddOrEven(1));
        }
    }
}
