using MediatR;

namespace UnitTestExercises.Application.Commands
{
    public class ReopenOrderCommand : IRequest<bool>
    {
        public string OrderId { get; set; }
    }
}