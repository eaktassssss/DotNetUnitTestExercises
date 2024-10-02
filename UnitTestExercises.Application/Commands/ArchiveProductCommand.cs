using MediatR;

namespace UnitTestExercises.Application.Commands
{
    public class ArchiveProductCommand : IRequest<bool>
    {
        public string ProductId { get; set; }
    }
}