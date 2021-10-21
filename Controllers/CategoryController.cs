using JohannasBaksida.Infrastructure.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JohannasBaksida.Infrastructure.Concrete;
using JohannasBaksida.Areas.Identity.Data.Entities;
using JohannasBaksida.Areas.Identity.Data.Web;

namespace JohannasBaksida.Controllers
{
    [Route("api/Category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager _manager;

        public CategoryController(ICategoryManager manager)
        {
            _manager = manager;
        }


        [Route("/VariableCostsCategory/Post")]
        [HttpPost]
        public void Post([FromBody] VariableCostsCategories variableCostsCategories)
        {
            _manager.Post(variableCostsCategories);
        }
        [Route("/VariableCostsCategory/Edit")]
        [HttpPost]
        public void Edit([FromBody] EditVariableCostCategoryDTO variableCostCategory)
        {
            _manager.Edit(variableCostCategory);
        }

        [Route("/FixedCostsCategories/Post")]
        [HttpPost]
        public void Post([FromBody] FixedCostsCategories fixedCostsCategories)
        {
            _manager.Post(fixedCostsCategories);
        }
        [Route("/FixedCostsCategories/Edit")]
        [HttpPost]
        public void Edit([FromBody] EditFixedCostCategoryDTO fixedCostsCategories)
        {
            _manager.Edit(fixedCostsCategories);
        }
    }
}

