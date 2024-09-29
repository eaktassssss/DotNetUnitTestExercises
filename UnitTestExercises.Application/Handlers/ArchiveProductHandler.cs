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
    public class ArchiveProductHandler : IRequestHandler<ArchiveProductCommand, bool>
    {
        private readonly IProductService _productService;

        public ArchiveProductHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<bool> Handle(ArchiveProductCommand request, CancellationToken cancellationToken)
        {
            return _productService.ArchiveProduct(request.ProductId);
        }
    }

}
