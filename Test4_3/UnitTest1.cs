using System;
using Xunit;
using Lab4_3;

namespace Test4_3
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3, 5)]
        [InlineData(10, 29)]

        public void Test1(int a, int expected)
        {

            int result = PrimeNumbers.GivePrime(a);

            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(3)]
        [InlineData(7)]
        public void Test2(int a)
        {

            bool result = PrimeNumbers.IsPrime(a);

            Assert.True(result);

        }
    }
}
