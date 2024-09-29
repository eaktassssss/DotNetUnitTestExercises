using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Application.Interfaces.Repositories;
using UnitTestExercises.Application.Models;
using UnitTestExercises.Application.Queries;
using UnitTestExercises.Core.Services;

namespace UnitTestExercises.Application.Handlers
{
    public class GetOrderByIdHandler : IRequestHandler<GetOrderByIdQuery, OrderModel>
    {
        private readonly IOrderService _orderService;

        public GetOrderByIdHandler(IOrderService  orderService)
        {
            _orderService = orderService;
        }

        public async Task<OrderModel> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var order =  _orderService.GetOrderById(request.OrderId);
            if (order == null) return null;

            return new OrderModel
            {
                Id = order.Id,
                CustomerId = order.CustomerId,
                Items = order.Items,
                TotalAmount = order.TotalAmount,
                OrderStatus = order.OrderStatus
            };
        }
    }

}
