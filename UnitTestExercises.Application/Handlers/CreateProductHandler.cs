using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Application.Commands;
using UnitTestExercises.Application.Models;
using UnitTestExercises.Application.Services;
using UnitTestExercises.Core.Services;

namespace UnitTestExercises.Application.Handlers
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, bool>
    {
        private readonly IProductService _productService;

        public CreateProductHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new ProductModel
            {
                Name = request.Name,
                Price = request.Price,
                StockQuantity = request.StockQuantity
            };

            return _productService.CreateProduct(product);
        }
    }

}
