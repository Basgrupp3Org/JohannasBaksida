using JohannasBaksida.Infrastructure.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JohannasBaksida.Infrastructure.Concrete;
using JohannasBaksida.Areas.Identity.Data.Entities;

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


        [Route("/VariableCostsCategory")]
        [HttpPost]
        public void Post([FromBody] VariableCostsCategories variableCostsCategories)
        {
            _manager.Post(variableCostsCategories);
        }


        [Route("/FixedCostsCategories")]
        [HttpPost]
        public void Post([FromBody] FixedCostsCategories fixedCostsCategories)
        {
            _manager.Post(fixedCostsCategories);
        }
    }
}

