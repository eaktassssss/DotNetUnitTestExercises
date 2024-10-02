using MediatR;

namespace UnitTestExercises.Application.Commands
{
    public class CancelOrderCommand : IRequest<bool>
    {
        public string OrderId { get; set; }
    }
}