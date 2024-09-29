using Moq;
using UnitTestExercises.Application.Interfaces.Repositories;
using UnitTestExercises.Application.Models;
using UnitTestExercises.Application.Services;
using UnitTestExercises.Core.Entities;
using UnitTestExercises.Tests.Fixtures;

namespace UnitTestExercises.Tests.ServiceTests
{
    public class ProductServiceTests : IClassFixture<ProductServiceFixture>
    {
        private readonly IProductService _productService;
        private readonly ProductServiceFixture _fixture;
        public ProductServiceTests(ProductServiceFixture fixture)
        {
            _fixture = fixture;
            _productService = fixture.ProductService;
        }
        public void CreateProduct_ValidProduct_ReturnTrue()
        {
            var product = new Product
            {
                Name = "Test",
                Price = 1500,
                StockQuantity = 60
            };

            var result = _productService.CreateProduct(new ProductModel
            {
                Name = "Test",
                Price = 1500,
                StockQuantity = 60
            });

            _fixture.ProductRepositoryMock.Setup(setup => setup.Add(product)).Returns(true);

            Assert.True(result);
        }
    }
}
