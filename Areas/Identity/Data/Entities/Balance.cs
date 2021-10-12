using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasBaksida.Areas.Identity.Data.Entities
{
    public class Balance : Entity
    {
        public virtual ICollection<BalanceChanged> BalanceChanges { get; set; }
    }

    public class BalanceChanged : Entity
    {
        public decimal OldSum { get; set; }
        public decimal NewSum { get; set; }
        public DateTime Date { get; set; }
    }
}
