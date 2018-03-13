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
            return Ok(new Response
            {
                Data = new Status()
            });
        }
    }
}