using MediatR;
using UnitTestExercises.Application.Models;

namespace UnitTestExercises.Application.Queries
{
    public class GetOrdersByCustomerQuery : IRequest<IEnumerable<OrderModel>>
    {
        public int CustomerId { get; set; }
    }
}