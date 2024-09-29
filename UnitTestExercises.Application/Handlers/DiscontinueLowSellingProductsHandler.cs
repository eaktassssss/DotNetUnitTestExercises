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
    public class DiscontinueLowSellingProductsHandler : IRequestHandler<DiscontinueLowSellingProductsCommand, bool>
    {
        private readonly IOrderService _orderService;

        public DiscontinueLowSellingProductsHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<bool> Handle(DiscontinueLowSellingProductsCommand request, CancellationToken cancellationToken)
        {
            return _orderService.DiscontinueLowSellingProducts(request.SalesThreshold);
        }
    }

}
