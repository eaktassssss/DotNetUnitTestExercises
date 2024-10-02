using MediatR;
using UnitTestExercises.Application.Models;

namespace UnitTestExercises.Application.Queries
{
    public class GetOutOfStockProductsQuery : IRequest<IEnumerable<ProductModel>>
    {
    }
}