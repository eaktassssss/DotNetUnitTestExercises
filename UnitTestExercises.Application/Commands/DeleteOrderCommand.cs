﻿using MediatR;

namespace UnitTestExercises.Application.Commands
{
    public class DeleteOrderCommand : IRequest<bool>
    {
        public string OrderId { get; set; }
    }
}