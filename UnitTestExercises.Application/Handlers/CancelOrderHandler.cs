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
    public class CancelOrderHandler : IRequestHandler<CancelOrderCommand, bool>
    {
        private readonly IOrderService _orderService;

        public CancelOrderHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<bool> Handle(CancelOrderCommand request, CancellationToken cancellationToken)
        {
            return _orderService.CancelOrder(request.OrderId);
        }
    }

}
