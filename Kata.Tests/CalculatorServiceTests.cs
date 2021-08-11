namespace Kata.Tests
{
    using Kata;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class CalculatorServiceTests
    {
        private CalculatorService _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new CalculatorService();
        }

        [Test]
        public void CanCalladd()
        {
            var i = 1067441755;
            var j = 1585444633;
            var result = _testClass.add(i, j);
            Assert.Fail("Create or modify test");
        }
    }
}