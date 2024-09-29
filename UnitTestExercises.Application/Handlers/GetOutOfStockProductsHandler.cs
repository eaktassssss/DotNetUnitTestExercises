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
    public class GetOutOfStockProductsHandler : IRequestHandler<GetOutOfStockProductsQuery, IEnumerable<ProductModel>>
    {
        private readonly IProductService _productService;

        public GetOutOfStockProductsHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IEnumerable<ProductModel>> Handle(GetOutOfStockProductsQuery request, CancellationToken cancellationToken)
        {
            return _productService.GetOutOfStockProducts();
        }
    }

}
