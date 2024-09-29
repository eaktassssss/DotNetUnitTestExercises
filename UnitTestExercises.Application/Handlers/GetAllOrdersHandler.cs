using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Application.Models;
using UnitTestExercises.Application.Queries;
using UnitTestExercises.Core.Services;

namespace UnitTestExercises.Application.Handlers
{
    public class GetAllOrdersHandler : IRequestHandler<GetAllOrdersQuery, IEnumerable<OrderModel>>
    {
        private readonly IOrderService _orderService;

        public GetAllOrdersHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<IEnumerable<OrderModel>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            return _orderService.GetAllOrders();
        }
    }

}
