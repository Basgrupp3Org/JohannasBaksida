using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasBaksida.Areas.Identity.Data.Entities
{
    public class Purchase : Entity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        //public virtual JohannasBaksidaUser User { get; set; }
        //public VariableCostsCategories VariableCostsCategory { get; set; }
    }
}
