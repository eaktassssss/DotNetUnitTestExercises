using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Application.Models;

namespace UnitTestExercises.Application.Queries
{
    public class GetOrderByIdQuery : IRequest<OrderModel>
    {
        public string OrderId { get; set; }
    }

}
