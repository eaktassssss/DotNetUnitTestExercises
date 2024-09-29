using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExercises.Application.Commands
{
    public class RestockProductCommand : IRequest<bool>
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }

}
