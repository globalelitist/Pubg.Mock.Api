using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pubg.Api.Models;
using Pubg.Api.Generators;

namespace Pubg.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/matches")]
    public class MatchesController : Controller
    {
        [HttpGet]
        public IEnumerable<Match> Get()
        {
            var numMatches = 5;

            var gen = new MatchGenerator();

            var matches = new List<Match>(numMatches);

            for (int i = 0; i < numMatches; i++)
            {
                matches.Add(gen.GenerateMatch());
            }

            return matches;
        }

        [HttpGet("{id}")]
        public Match Get(string matchId)
        {
            return new MatchGenerator().GenerateMatch(matchId);
        }
    }
}