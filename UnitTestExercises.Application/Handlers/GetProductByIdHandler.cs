using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Application.Models;
using UnitTestExercises.Application.Queries;
using UnitTestExercises.Application.Services;
using UnitTestExercises.Core.Services;

namespace UnitTestExercises.Application.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, ProductModel>
    {
        private readonly IProductService _productService;

        public GetProductByIdHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<ProductModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product=_productService.GetProductById(request.ProductId);

            if (product!=null)
                return product;

            return null;
        }
    }

}
