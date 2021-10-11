﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasBaksida.Areas.Identity.Data.Entities
{
    public class SavingGoal
    {
        [Key]
        public Guid Id { get; set; }

        public virtual JohannasBaksidaUser User { get; set; }
    }
}
