namespace Kata.Api.Tests.Controllers
{
    using Kata.Api.Controllers;
    using System;
    using NUnit.Framework;
    using Moq;
    using Microsoft.Extensions.Logging;

    [TestFixture]
    public class WeatherForecastControllerTests
    {
        private WeatherForecastController _testClass;
        private ILogger<WeatherForecastController> _logger;

        [SetUp]
        public void SetUp()
        {
            _testClass = new WeatherForecastController(new Mock<ILogger<WeatherForecastController>>().Object);
            _logger = new Mock<ILogger<WeatherForecastController>>().Object;
        }

        [Test]
        public void CanCallGet()
        {
            var result = _testClass.Get();
            //Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new WeatherForecastController(_logger);
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CannotConstructWithNullLogger()
        {
            Assert.Throws<ArgumentNullException>(() => new WeatherForecastController(default(ILogger<WeatherForecastController>)));
        }
    }
}