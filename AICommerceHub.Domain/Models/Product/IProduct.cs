﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AICommerceHub.Domain.Models.NewFolder
{
    internal interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        string? Description { get; set; }
        short Stock { get; set; }

    }
}
