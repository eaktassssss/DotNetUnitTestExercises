using MediatR;

namespace UnitTestExercises.Application.Commands
{
    public class DiscontinueLowSellingProductsCommand : IRequest<bool>
    {
        public int SalesThreshold { get; set; }
    }
}