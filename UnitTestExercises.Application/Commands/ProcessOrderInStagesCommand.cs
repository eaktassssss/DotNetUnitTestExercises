using MediatR;
using UnitTestExercises.Core.Enums;

namespace UnitTestExercises.Application.Commands
{
    public class ProcessOrderInStagesCommand : IRequest<bool>
    {
        public string OrderId { get; set; }
        public List<OrderStatus> Stages { get; set; }
    }
}