using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Application.Models;

namespace UnitTestExercises.Application.Commands
{
    public class UpdateOrderItemsCommand : IRequest<bool>
    {
        public string OrderId { get; set; }
        public List<OrderItemModel> UpdatedItems { get; set; }
    }

}
