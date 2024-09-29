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
    public class PartialShipOrderHandler : IRequestHandler<PartialShipOrderCommand, bool>
    {
        private readonly IOrderService _orderService;

        public PartialShipOrderHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<bool> Handle(PartialShipOrderCommand request, CancellationToken cancellationToken)
        {
            return _orderService.PartialShipOrder(request.OrderId, request.ShippedItems);
        }
    }

}
