namespace Kata.Api.Tests.ApiControllers
{
    using Kata.Api.ApiControllers;
    using System;
    using NUnit.Framework;    
    using Moq;
    using Kata.Api;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Results;

    [TestFixture]
    public class ProductsControllerTests
    {
        private ProductsController _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new ProductsController(new Mock<IProductRepository>().Object);
        }

        [Test]
        public void CanCallGet()
        {
            var id = 290630049;
            var result = _testClass.Get(id);
            //Assert.Fail("Create or modify test");
        }

        [Test]
        public void GetReturnsProduct()
        {
            // Arrange

            _testClass.Request = new HttpRequestMessage();
            _testClass.Configuration = new HttpConfiguration();

            // Act
            var response = _testClass.Get(10);

            // Assert
            Product product;
            Assert.IsTrue(response.TryGetContentValue<Product>(out product));
            Assert.AreEqual(10, product.Id);
        }

        [Test]
        public void DeleteReturnsOk()
        {
            // Arrange

            // Act
            IHttpActionResult actionResult = _testClass.Delete(10);

            // Assert
            Assert.IsInstanceOf(typeof(OkResult) , actionResult);
        }
    }
}