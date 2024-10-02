using MediatR;

namespace UnitTestExercises.Application.Commands
{
    public class DiscountProductCommand : IRequest<bool>
    {
        public string ProductId { get; set; }
        public decimal DiscountPercentage { get; set; }
    }
}