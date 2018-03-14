using System;
using Calculator;
using NUnit.Framework;

namespace WhiteBoxUnitTests
{
    [TestFixture]
    public class Tests
    {

        [Test(Description = "Test #1 Female,17 returns 0.0")]
        public void Test1()
        {
            var sut = new Calc();

            Assert.That(sut.CalcPremium(17, "female") == 0.0f);
        }

        [Test(Description = "Test #2 Female,24 returns 5.0")]
        public void Test2()
        {
            var sut = new Calc();

            Assert.That(sut.CalcPremium(24, "female") == 5.0f);
        }

        [Test(Description = "Test #3 Female,31 returns 2.5")]
        public void Test3()
        {
            var sut = new Calc();

            Assert.That(sut.CalcPremium(31, "female") == 2.5f);
        }

        [Test(Description = "Test #4 Female,50 returns 0.375")]
        public void Test4()
        {
            var sut = new Calc();

            Assert.That(sut.CalcPremium(50, "female") == 0.375f);
        }

        [Test(Description = "Test #5 Male,17 returns 0.0")]
        public void Test5()
        {
            var sut = new Calc();

            Assert.That(sut.CalcPremium(17, "male") == 0.0f);
        }

        [Test(Description = "Test #6 Male,27 returns 6.0")]
        public void Test6()
        {
            var sut = new Calc();

            Assert.That(sut.CalcPremium(27, "male") == 6.0f);
        }

        [Test(Description = "Test #7 Male,36 returns 5.0")]
        public void Test7()
        {
            var sut = new Calc();

            Assert.That(sut.CalcPremium(36, "male") == 5.0f);
        }

        [Test(Description = "Test #8 Male,51 returns 6.0")]
        public void Test8()
        {
            var sut = new Calc();

            Assert.That(sut.CalcPremium(51, "male") == 0.75f);
        }

        [Test(Description = "Test #9 Other,51 returns 0.0")]
        public void Test9()
        {
            var sut = new Calc();

            Assert.That(sut.CalcPremium(50, "other") == 0.0f);
        }

        [Test(Description = "Test #10 Other,32 returns 0.0")]
        public void Test10()
        {
            var sut = new Calc();

            Assert.That(sut.CalcPremium(32, "other") == 0.0f);
        }

        [Test(Description = "Test Extra #1 Male,10 returns 0.0")]
        public void TestExtra1()
        {
            var sut = new Calc();

            Assert.That(sut.CalcPremium(10, "male") == 0.0f);
        }

        [Test(Description = "Test Extra #2 Female,88 returns 15.5")]
        public void TestExtra2()
        {
            var sut = new Calc();

            Assert.That(sut.CalcPremium(88, "female") == 15.5f);
        }

        [Test(Description = "Test Extra #3 Other,10 check if returns negative")]
        public void TestExtra3()
        {
            var sut = new Calc();

            Assert.Negative(sut.CalcPremium(10, "other"));
        }

        [Test(Description = "Test Extra #4 Female,16 Check if not zero")]
        public void TestExtra4()
        {
            var sut = new Calc();

            Assert.NotZero(sut.CalcPremium(16, "female"));
        }
    }
}
