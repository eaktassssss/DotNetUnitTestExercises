using MediatR;
using UnitTestExercises.Application.Models;
using UnitTestExercises.Application.Queries;
using UnitTestExercises.Core.Services;

namespace UnitTestExercises.Application.Handlers
{
    public class GetOrderHandler : IRequestHandler<GetOrderQuery, OrderModel>
    {
        private readonly IOrderService _orderService;

        public GetOrderHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<OrderModel> Handle(GetOrderQuery query, CancellationToken cancellationToken)
        {
            return _orderService.GetOrderById(query.OrderId);
        }
    }
}
