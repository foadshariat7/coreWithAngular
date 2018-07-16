using basicAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basicAPI.Controllers
{
    public class Test : Controller
    {
        private CompanyContext _ctx;
        public Test(CompanyContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet("api/test")]
        public IActionResult TestDatabase()
        {
            return Ok();
        }
    }
}
