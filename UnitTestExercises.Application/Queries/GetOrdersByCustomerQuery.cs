﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Application.Models;

namespace UnitTestExercises.Application.Queries
{
    public class GetOrdersByCustomerQuery : IRequest<IEnumerable<OrderModel>>
    {
        public int CustomerId { get; set; }
    }
}
