using JohannasBaksida.Areas.Identity.Data.Entities;
using JohannasBaksida.Areas.Identity.Data.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasBaksida.Infrastructure.Abstract
{
   public interface ICategoryManager
    {
        void Post(VariableCostsCategories variableCostsCategories);

        void Post(FixedCostsCategories fixedCostsCategories);

        void Edit(EditVariableCostCategoryDTO variableCostCategory);
        
        void Edit(EditFixedCostCategoryDTO fixedCostCategory);
    }
}
