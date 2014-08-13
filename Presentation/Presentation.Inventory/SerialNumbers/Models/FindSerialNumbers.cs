﻿using Demo.Application.Inventory.SerialNumbers;
using Demo.Library.Queries;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Presentation.Inventory.SerialNumbers.Models
{
    [Route("/serials", "GET")]
    public class FindSerialNumbers : PagedQuery
    {

        public String Serial { get; set; }
        public DateTime? Effective { get; set; }

        public Guid? ItemId { get; set; }
    }
}