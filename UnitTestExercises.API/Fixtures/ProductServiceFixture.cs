using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Application.Interfaces.Repositories;
using UnitTestExercises.Application.Services;
using UnitTestExercises.Infrastructure.Implementations.Services;

namespace UnitTestExercises.Tests.Fixtures
{
    public  class ProductServiceFixture
    {
        public IProductService ProductService { get; private set; }

        public Mock<IProductRepository> ProductRepositoryMock { get; private set; }
        public ProductServiceFixture()
        {
            ProductRepositoryMock =new Mock<IProductRepository>();
            ProductService = new ProductService(ProductRepositoryMock.Object);
        }
    }
}
