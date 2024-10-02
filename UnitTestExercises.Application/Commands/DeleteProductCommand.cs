using MediatR;

namespace UnitTestExercises.Application.Commands
{
    public class DeleteProductCommand : IRequest<bool>
    {
        public string ProductId { get; set; }
    }
}