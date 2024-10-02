using MediatR;

namespace UnitTestExercises.Application.Commands
{
    public class RefundOrderCommand : IRequest<bool>
    {
        public string OrderId { get; set; }
    }
}