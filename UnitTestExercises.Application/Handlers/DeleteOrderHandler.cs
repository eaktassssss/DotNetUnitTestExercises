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
    public class DeleteOrderHandler : IRequestHandler<DeleteOrderCommand, bool>
    {
        private readonly IOrderService _orderService;

        public DeleteOrderHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<bool> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            return _orderService.DeleteOrder(request.OrderId);
        }
    }

}
