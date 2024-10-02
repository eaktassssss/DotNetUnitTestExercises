using MediatR;
using UnitTestExercises.Application.Commands;
using UnitTestExercises.Application.Services;

namespace UnitTestExercises.Application.Handlers
{
    public class DiscountProductHandler : IRequestHandler<DiscountProductCommand, bool>
    {
        private readonly IProductService _productService;

        public DiscountProductHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<bool> Handle(DiscountProductCommand request, CancellationToken cancellationToken)
        {
            return _productService.DiscountProduct(request.ProductId, request.DiscountPercentage);
        }
    }
}