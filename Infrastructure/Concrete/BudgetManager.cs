using JohannasBaksida.Areas.Identity.Data.Entities;
using JohannasBaksida.Data;
using JohannasBaksida.Infrastructure.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasBaksida.Infrastructure.Concrete
{
    public class BudgetManager : IBudgetManager
    {
        private readonly JohannasBaksidaContext _context;

        public BudgetManager()
        {
        }

        public BudgetManager(JohannasBaksidaContext context) => _context = context;

        public void Post(Budget budget)
        {
            _context.Budgets.Add(budget);
            _context.SaveChanges();
        }
    }
}
