using MediatR;

namespace UnitTestExercises.Application.Commands
{
    public class RestockProductCommand : IRequest<bool>
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}