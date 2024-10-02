using MediatR;
using UnitTestExercises.Application.Models;

namespace UnitTestExercises.Application.Queries
{
    public class GetProductByIdQuery : IRequest<ProductModel>
    {
        public string ProductId { get; set; }
    }
}