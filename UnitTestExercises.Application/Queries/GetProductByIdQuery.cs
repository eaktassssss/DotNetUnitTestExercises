﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExercises.Application.Models;

namespace UnitTestExercises.Application.Queries
{
    public class GetProductByIdQuery : IRequest<ProductModel>
    {
        public string ProductId { get; set; }
    }
}
