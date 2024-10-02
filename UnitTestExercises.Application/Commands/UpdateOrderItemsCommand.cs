using MediatR;
using UnitTestExercises.Application.Models;

namespace UnitTestExercises.Application.Commands
{
    public class UpdateOrderItemsCommand : IRequest<bool>
    {
        public string OrderId { get; set; }
        public List<OrderItemModel> UpdatedItems { get; set; }
    }
}