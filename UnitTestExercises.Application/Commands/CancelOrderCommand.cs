﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExercises.Application.Commands
{
    public class CancelOrderCommand : IRequest<bool>
    {
        public string OrderId { get; set; }
    }

}
