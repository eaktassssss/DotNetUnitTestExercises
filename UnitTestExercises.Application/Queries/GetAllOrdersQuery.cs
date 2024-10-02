using MediatR;
using UnitTestExercises.Application.Models;

namespace UnitTestExercises.Application.Queries
{
    public class GetAllOrdersQuery : IRequest<IEnumerable<OrderModel>>
    {
    }
}