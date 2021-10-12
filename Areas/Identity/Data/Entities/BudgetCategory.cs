using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasBaksida.Areas.Identity.Data.Entities
{
    public class BudgetCategory : Entity
    {
        public virtual ICollection<Budget> Budgets { get; set; }
        public virtual JohannasBaksidaUser User { get; set; }

    }
    public class VariableCostsCategories : Entity
    {
        public string Name { get; set; }
        public decimal ToSpend { get; set; }
        public decimal Spent { get; set; }
    }

    public class FixedCostsCategories : Entity
    {
        public string Name { get; set; }
        public decimal Sum { get; set; }
    }
}
