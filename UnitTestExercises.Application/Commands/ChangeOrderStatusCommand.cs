using MediatR;
using UnitTestExercises.Core.Enums;

namespace UnitTestExercises.Application.Commands
{
    public class ChangeOrderStatusCommand : IRequest<bool>
    {
        public string OrderId { get; set; }
        public OrderStatus NewStatus { get; set; }
    }
}