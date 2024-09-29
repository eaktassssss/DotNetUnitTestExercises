﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExercises.Application.Commands
{
    public class ArchiveProductCommand : IRequest<bool>
    {
        public string ProductId { get; set; }
    }
}
