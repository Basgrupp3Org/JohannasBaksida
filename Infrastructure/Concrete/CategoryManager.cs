using JohannasBaksida.Areas.Identity.Data.Entities;
using JohannasBaksida.Data;
using JohannasBaksida.Infrastructure.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasBaksida.Infrastructure.Concrete
{
    public class CategoryManager : ICategoryManager
    {
        private readonly JohannasBaksidaContext _context;

        public CategoryManager()
        {
        }

        public CategoryManager(JohannasBaksidaContext context) => _context = context;

        public void Post(VariableCostsCategories variableCostsCategories)
        {
            _context.Add(variableCostsCategories);
            _context.SaveChanges();
                
        }

        public void Post(FixedCostsCategories fixedCostsCategories)
        {
            _context.Add(fixedCostsCategories);
            _context.SaveChanges();
        }
    }
}
