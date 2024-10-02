using MediatR;
using UnitTestExercises.Application.Commands;
using UnitTestExercises.Core.Services;

namespace UnitTestExercises.Application.Handlers
{
    public class CompleteOrderHandler : IRequestHandler<CompleteOrderCommand, bool>
    {
        private readonly IOrderService _orderService;

        public CompleteOrderHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<bool> Handle(CompleteOrderCommand request, CancellationToken cancellationToken)
        {
            return _orderService.CompleteOrder(request.OrderId);
        }
    }
}