using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Application.Commands;
using UnitTestExercises.Core.Services;

namespace UnitTestExercises.Application.Handlers
{
    public class ReturnOrderHandler : IRequestHandler<ReturnOrderCommand, bool>
    {
        private readonly IOrderService _orderService;

        public ReturnOrderHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<bool> Handle(ReturnOrderCommand request, CancellationToken cancellationToken)
        {
            return _orderService.ReturnOrder(request.OrderId, request.ReturnedItems);
        }
    }

}
