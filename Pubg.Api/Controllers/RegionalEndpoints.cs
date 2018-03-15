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
        public IActionResult GetMatches()
        {
            var numMatches = 5;

            var gen = new MatchGenerator();

            var matches = new List<MatchAttributes>(numMatches);

            for (int i = 0; i < numMatches; i++)
            {
                matches.Add(gen.GenerateMatch());
            }

            return Ok(new Response
            {
                Data = matches
            });
        }

        [HttpGet("matches/{matchId}")]
        public IActionResult GetMatch(string matchId)
        {
            if (matchId == Guid.Empty.ToString())
            {
                return NotFound(new Response
                {
                    Data = new
                    {
                        Title = "Not Found"
                    }
                });
            }

            return Ok(new Response
            {
                Data = new MatchGenerator().GenerateMatch(matchId)
            });
        }
    }
}