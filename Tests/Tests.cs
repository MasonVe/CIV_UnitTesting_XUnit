using System;
using Xunit;
using CalcLib;

namespace Tests
{
    public class UnitTest1
    {

        RecursiveCalc rc1 = new RecursiveCalc();

        // FibRec Test (Fact)
        [Fact]
        public void FibRec_Test()
        {
            Assert.Equal(1, rc1.FibonacciRec(3,5,7));
        }

        // FibRec Test (Theory)
        [Theory]
        [InlineData(1,3,5,7)]
        public void FibRecTheory_Test(int expected, int num1, int num2, int numFibs)
        {
            Assert.Equal(expected, rc1.FibonacciRec(num1, num2, numFibs));
        }



        // FactorialRec Test (Fact)
        [Fact]
        public void FacRec_Test()
        {
            Assert.Equal(1, rc1.FactorialRec(0,1));

            Assert.Equal(24, rc1.FactorialRec(4,1));
        }
        

        // FactorialRec Test (Theory)
        [Theory]
        [InlineData(1,0,1)]
        [InlineData(24,4,1)]

        public void FacRecTheory_Test(int expected, int input, int ans)
        {
            Assert.Equal(expected, rc1.FactorialRec(input, ans));
        }
        

        // PrimeCheckRec Test (Fact)
        [Fact]
        public void PrimeCheck_Test()
        {
            Assert.True(rc1.PrimeCheckRec(29,2));
        }


        // PrimeCheckRec Test (Theory)
        [Theory]
        [InlineData(73,2)]

        public void PrimeCheckTheory_Test(int num, int divisor)
        {
            Assert.True(rc1.PrimeCheckRec(num, divisor));
        }

        // DivideByZeroException Test (Fact)
        [Fact]
        public void DivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() => rc1.PrimeCheckRec(29,0));
        }




        // FibRec Test (Fact)
        [Fact]
        public void FibCheck_Test()
        {
            Assert.True(rc1.FibCheck(8));
            Assert.False(rc1.FibCheck(12));
        }
    }
}
