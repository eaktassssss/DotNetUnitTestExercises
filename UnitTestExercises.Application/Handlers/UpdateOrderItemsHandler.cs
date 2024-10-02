using MediatR;
using UnitTestExercises.Application.Commands;
using UnitTestExercises.Core.Services;

namespace UnitTestExercises.Application.Handlers
{
    public class UpdateOrderItemsHandler : IRequestHandler<UpdateOrderItemsCommand, bool>
    {
        private readonly IOrderService _orderService;

        public UpdateOrderItemsHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<bool> Handle(UpdateOrderItemsCommand request, CancellationToken cancellationToken)
        {
            return _orderService.UpdateOrderItems(request.OrderId, request.UpdatedItems);
        }
    }
}