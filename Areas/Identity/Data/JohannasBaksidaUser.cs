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
    }
}
