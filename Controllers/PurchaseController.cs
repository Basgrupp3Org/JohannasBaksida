﻿using JohannasBaksida.Areas.Identity.Data.Entities;
using JohannasBaksida.Areas.Identity.Data.Managers;
using JohannasBaksida.Data;
using JohannasBaksida.Infrastructure.Abstract;
using JohannasBaksida.Infrastructure.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasBaksida.Controllers
{
    [Route("api/Purchase")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly IPurchaseManager _manager;

        public PurchaseController(IPurchaseManager manager)
        {
            _manager = manager;
        }

       

        [HttpPost]
        public void Post([FromBody] Purchase purchase)
        {
            _manager.Post(purchase);
        }
    }
}
