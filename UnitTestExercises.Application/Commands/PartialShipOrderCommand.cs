using MediatR;
using UnitTestExercises.Application.Models;

namespace UnitTestExercises.Application.Commands
{
    public class PartialShipOrderCommand : IRequest<bool>
    {
        public string OrderId { get; set; }
        public List<OrderItemModel> ShippedItems { get; set; }
    }
}