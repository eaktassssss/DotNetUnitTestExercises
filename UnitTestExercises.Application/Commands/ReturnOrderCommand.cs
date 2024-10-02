using MediatR;
using UnitTestExercises.Application.Models;

namespace UnitTestExercises.Application.Commands
{
    public class ReturnOrderCommand : IRequest<bool>
    {
        public string OrderId { get; set; }
        public List<OrderItemModel> ReturnedItems { get; set; }
    }
}