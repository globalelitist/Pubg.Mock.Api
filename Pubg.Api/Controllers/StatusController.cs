using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pubg.Api.Models;

namespace Pubg.Api.Controllers
{
    [Produces("application/json")]
    [Route("/status")]
    public class StatusController : Controller
    {
        public IActionResult Get()
        {
            return Ok(new Status());
        }
    }
}