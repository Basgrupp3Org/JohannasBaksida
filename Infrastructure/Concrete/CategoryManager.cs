using JohannasBaksida.Areas.Identity.Data.Entities;
using JohannasBaksida.Areas.Identity.Data.Web;
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

        public void Edit(EditVariableCostCategoryDTO variableCostCategory)
        {
            var foundVariableCategory = _context.VariableCostsCategories.Where(x => x.Id == variableCostCategory.Id).FirstOrDefault();
            if (foundVariableCategory != null)
            {
                foundVariableCategory.Name = variableCostCategory.Name;
                foundVariableCategory.ToSpend = variableCostCategory.ToSpend;
                foundVariableCategory.Spent = variableCostCategory.Spent;
              
                _context.SaveChanges();
            }
        }

        public void Edit(EditFixedCostCategoryDTO fixedCostsCategories)
        {
            var foundFixedCategory = _context.FixedCostsCategories.Where(x => x.Id == fixedCostsCategories.Id).FirstOrDefault();
            if (foundFixedCategory != null)
            {
                foundFixedCategory.Name = fixedCostsCategories.Name;
                foundFixedCategory.Sum = fixedCostsCategories.Sum;
                foundFixedCategory.Cost = fixedCostsCategories.Cost;

                _context.SaveChanges();
            }
        }
    }
}
