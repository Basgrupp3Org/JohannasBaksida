using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JohannasBaksida.Areas.Identity.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace JohannasBaksida.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the JohannasBaksidaUser class
    public class JohannasBaksidaUser : IdentityUser
    {
   
        public virtual ICollection<SavingGoal> SavingGoals { get; set; }
        public virtual ICollection<Budget> Budgets { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<Balance> Balance { get; set; }
        public virtual ICollection<VariableCostsCategories> VariableCostsCategories { get; set; }
        public virtual ICollection<FixedCostsCategories> FixedCostsCategories { get; set; }
        public virtual ICollection<BalanceChanged> BalanceChanges { get; set; }
        public decimal BalanceUser { get; set; }

    }
}
