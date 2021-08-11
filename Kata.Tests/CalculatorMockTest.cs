using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Tests
{
    public class CalculatorMockTest
    {
        Mock<ICalculatorService> service = null;
        CalculatorMock calMock = null;

        [SetUp]
        public void Setup()
        {
            service = new Mock<ICalculatorService>();
            calMock = new CalculatorMock(service.Object);
        }

        [Test]
        public void Perform()
        {
            service.Setup(x => x.add(It.IsAny<int>(), It.IsAny<int>()))
            .Returns(5);

            Assert.AreEqual(5, calMock.Perform(2,3));

            service.Verify(x => x.add(It.IsAny<int>(), It.IsAny<int>()), Times.Once);                
        }
    }
}
