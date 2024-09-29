using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Application.Commands;
using UnitTestExercises.Application.Services;
using UnitTestExercises.Core.Services;

namespace UnitTestExercises.Application.Handlers
{
    public class RestockProductHandler : IRequestHandler<RestockProductCommand, bool>
    {
        private readonly IProductService _productService;

        public RestockProductHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<bool> Handle(RestockProductCommand request, CancellationToken cancellationToken)
        {
            return _productService.RestockProduct(request.ProductId, request.Quantity);
        }
    }

}
