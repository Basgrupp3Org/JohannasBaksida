using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasBaksida.Areas.Identity.Data.Entities
{
    public class SavingGoal : Entity
    {
        public decimal ToSave { get; set; }
        public string Name { get; set; }
        public decimal Saved { get; set; }
        public virtual JohannasBaksidaUser User { get; set; }
    }
}
