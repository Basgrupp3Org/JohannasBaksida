using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasBaksida.Areas.Identity.Data.Entities
{
    public class Balance
    {
        public virtual ICollection<BalanceChanged> BalanceChagnes { get; set; }
    }

    public class BalanceChanged
    {

    }
}
