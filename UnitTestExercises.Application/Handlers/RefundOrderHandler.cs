﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Application.Commands;
using UnitTestExercises.Core.Services;

namespace UnitTestExercises.Application.Handlers
{
    public class RefundOrderHandler : IRequestHandler<RefundOrderCommand, bool>
    {
        private readonly IOrderService _orderService;

        public RefundOrderHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<bool> Handle(RefundOrderCommand request, CancellationToken cancellationToken)
        {
            return _orderService.RefundOrder(request.OrderId);
        }
    }

}
