﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasBaksida.Areas.Identity.Data.Web
{
    public class EditVariableCostCategoryDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal ToSpend { get; set; }
        public decimal Spent { get; set; }
    }
}
