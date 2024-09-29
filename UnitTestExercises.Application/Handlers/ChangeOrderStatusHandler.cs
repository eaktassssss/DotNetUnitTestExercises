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
    public class ChangeOrderStatusHandler : IRequestHandler<ChangeOrderStatusCommand, bool>
    {
        private readonly IOrderService _orderService;

        public ChangeOrderStatusHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<bool> Handle(ChangeOrderStatusCommand request, CancellationToken cancellationToken)
        {
            return _orderService.ChangeOrderStatus(request.OrderId, request.NewStatus);
        }
    }

}
