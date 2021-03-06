using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasBaksida.Areas.Identity.Data.Web
{
    public class EditBudgetDTO
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Income { get; set; }
        public decimal Housing { get; set; }
        public decimal Vehicle { get; set; }
        public decimal Unbudgeted { get; set; }
    }
}
