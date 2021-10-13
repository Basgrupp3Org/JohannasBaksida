using JohannasBaksida.Areas.Identity.Data.Entities;
using JohannasBaksida.Infrastructure.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasBaksida.Controllers
{
    [Route("api/Budget")]
    [ApiController]
    public class BudgetController : ControllerBase
    {
        private readonly IBudgetManager _manager;

        public BudgetController(IBudgetManager manager) => _manager = manager;

        [HttpPost]
        public void Post([FromBody] Budget budget)
        {
            _manager.Post(budget);
        }
    }
}
