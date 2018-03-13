using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pubg.Api.Models;
using Pubg.Api.Generators;

namespace Pubg.Api.Controllers
{
    [Produces("application/json")]
    [Route("/matches")]
    public class MatchesController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var numMatches = 5;

            var gen = new MatchGenerator();

            var matches = new List<Match>(numMatches);

            for (int i = 0; i < numMatches; i++)
            {
                matches.Add(gen.GenerateMatch());
            }

            return Ok(matches);
        }

        [HttpGet("{matchId}")]
        public IActionResult Get(string matchId)
        {
            if(matchId == Guid.Empty.ToString())
            {
                return NotFound(new
                {
                    Title = "Not Found"
                });
            }

            return Ok(new MatchGenerator().GenerateMatch(matchId));
        }
    }
}