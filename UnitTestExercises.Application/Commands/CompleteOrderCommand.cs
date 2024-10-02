using MediatR;

namespace UnitTestExercises.Application.Commands
{
    public class CompleteOrderCommand : IRequest<bool>
    {
        public string OrderId { get; set; }
    }
}