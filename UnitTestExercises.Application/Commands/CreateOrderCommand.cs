using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Application.Models;

namespace UnitTestExercises.Application.Commands
{

    public class CreateOrderCommand : IRequest<bool>
    {
        public string Id { get; set; }
        public int CustomerId { get; set; }
        public List<OrderItemModel> Items { get; set; }
    }

}
