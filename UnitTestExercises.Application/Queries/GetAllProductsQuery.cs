using MediatR;
using UnitTestExercises.Application.Models;

namespace UnitTestExercises.Application.Queries
{
    public class GetAllProductsQuery : IRequest<IEnumerable<ProductModel>>
    {
    }
}