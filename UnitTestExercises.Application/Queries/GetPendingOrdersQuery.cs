using MediatR;
using UnitTestExercises.Application.Models;

namespace UnitTestExercises.Application.Queries
{
    public class GetPendingOrdersQuery : IRequest<IEnumerable<OrderModel>>
    {
    }
}