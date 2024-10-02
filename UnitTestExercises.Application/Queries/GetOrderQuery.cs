using MediatR;
using UnitTestExercises.Application.Models;

namespace UnitTestExercises.Application.Queries
{
    public class GetOrderQuery : IRequest<OrderModel>
    {
        public string OrderId { get; set; }
    }
}