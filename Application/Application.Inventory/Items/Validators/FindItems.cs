﻿using Demo.Library.Queries.Validation;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Inventory.Items.Validators
{
    public class FindItems : BasicQueryValidator<Queries.FindItems>
    {
        public FindItems()
            : base()
        {
        }
    }
}