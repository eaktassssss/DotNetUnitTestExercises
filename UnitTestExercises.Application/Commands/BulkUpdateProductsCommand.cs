using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Application.Models;

namespace UnitTestExercises.Application.Commands
{
    public class BulkUpdateProductsCommand : IRequest<bool>
    {
        public List<ProductModel> Products { get; set; }
    }

}
