using MediatR;
using UnitTestExercises.Application.Models;

namespace UnitTestExercises.Application.Commands
{
    public class BulkUpdateProductsCommand : IRequest<bool>
    {
        public List<ProductModel> Products { get; set; }
    }
}