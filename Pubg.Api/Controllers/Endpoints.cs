using Microsoft.AspNetCore.Mvc;
using Pubg.Api.Models;

namespace Pubg.Api.Controllers
{
    public class Endpoints : Controller
    {
        [HttpGet("status")]
        public IActionResult GetStatus()
        {
            return Ok(new Response
            {
                Data = new[] 
                {
                    new Status()
                }
            });
        }
    }
}
