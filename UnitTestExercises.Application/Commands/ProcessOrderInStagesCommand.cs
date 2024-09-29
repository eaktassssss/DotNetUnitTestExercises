using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Core.Enums;

namespace UnitTestExercises.Application.Commands
{
    public class ProcessOrderInStagesCommand : IRequest<bool>
    {
        public string OrderId { get; set; }
        public List<OrderStatus> Stages { get; set; }
    }

}
