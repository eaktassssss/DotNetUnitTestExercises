using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Application.Commands;
using UnitTestExercises.Application.Services;

namespace UnitTestExercises.Application.Handlers
{
    public class BulkUpdateProductsHandler : IRequestHandler<BulkUpdateProductsCommand, bool>
    {
        private readonly IProductService _productService;

        public BulkUpdateProductsHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<bool> Handle(BulkUpdateProductsCommand request, CancellationToken cancellationToken)
        {
            return _productService.BulkUpdateProducts(request.Products);
        }
    }

}
