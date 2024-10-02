using MediatR;
using UnitTestExercises.Application.Models;

namespace UnitTestExercises.Application.Commands
{
    public class CreateOrderCommand : IRequest<bool>
    {
        public string Id { get; set; }
        public int CustomerId { get; set; }
        public List<OrderItemModel> Items { get; set; }
    }
}