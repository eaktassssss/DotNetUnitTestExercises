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
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<ProductModel>>
    {
        private readonly IProductService _productService;

        public GetAllProductsHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IEnumerable<ProductModel>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return _productService.GetAllProducts();
        }
    }

}
