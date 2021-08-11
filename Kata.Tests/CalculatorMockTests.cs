namespace Kata.Tests
{
    using Kata;
    using System;
    using NUnit.Framework;
    using Moq;

    [TestFixture]
    public class CalculatorMockTests
    {
        private CalculatorMock _testClass;
        private ICalculatorService _service;

        [SetUp]
        public void SetUp()
        {
            _service = new Mock<ICalculatorService>().Object;
            _testClass = new CalculatorMock(_service);
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new CalculatorMock(_service);
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CannotConstructWithNullService()
        {
            Assert.Throws<ArgumentNullException>(() => new CalculatorMock(default(ICalculatorService)));
        }

        [Test]
        public void CanCallPerform()
        {
            var i = 1348129043;
            var j = 173469967;
            var result = _testClass.Perform(i, j);
            Assert.Fail("Create or modify test");
        }
    }
}