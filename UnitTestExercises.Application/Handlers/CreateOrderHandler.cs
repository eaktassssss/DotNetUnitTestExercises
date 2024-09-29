using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Application.Commands;
using UnitTestExercises.Application.Models;
using UnitTestExercises.Core.Entities;
using UnitTestExercises.Core.Enums;
using UnitTestExercises.Core.Services;

namespace UnitTestExercises.Application.Handlers
{
    public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, bool>
    {
        private readonly IOrderService _orderService;

        public CreateOrderHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var newOrder = new OrderModel
            {

                CustomerId = request.CustomerId,
                Items = request.Items.Select(i => new OrderItemModel
                {
                    ProductId = i.ProductId,
                    Quantity = i.Quantity,
                    Price = i.Price
                }).ToList(),
                TotalAmount = request.Items.Sum(i => i.Price * i.Quantity),
                OrderStatus = OrderStatus.Pending
            };

             _orderService.CreateOrder(newOrder);
            return true;
        }
    }

}
