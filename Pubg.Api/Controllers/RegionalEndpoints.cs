using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pubg.Api.Models;
using Pubg.Api.Generators;

namespace Pubg.Api.Controllers
{
    [Produces("application/json")]
    [Route("/shards/{shardId}")]
    public class RegionalEndpoints : Controller
    {
        [HttpGet("matches")]
        public IActionResult GetMatches(string shardId)
        {
            //stub
            return Ok();
        }

        [HttpGet("matches/{matchId}")]
        public IActionResult GetMatch(string matchId, string shardId)
        {
            if (matchId == Guid.Empty.ToString())
            {
                return NotFound();
            }

            return Ok(ResponseGenerator.GenerateResponse(2, shardId));
        }
    }
}