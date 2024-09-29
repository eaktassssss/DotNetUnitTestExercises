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
    public class GetOrdersByCustomerHandler : IRequestHandler<GetOrdersByCustomerQuery, IEnumerable<OrderModel>>
    {
        private readonly IOrderService _orderService;

        public GetOrdersByCustomerHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<IEnumerable<OrderModel>> Handle(GetOrdersByCustomerQuery request, CancellationToken cancellationToken)
        {
            return _orderService.GetOrdersByCustomer(request.CustomerId);
        }
    }

}
