using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Core.Enums;

namespace UnitTestExercises.Application.Commands
{
    public class ChangeOrderStatusCommand : IRequest<bool>
    {
        public string OrderId { get; set; }
        public OrderStatus NewStatus { get; set; }
    }

}
