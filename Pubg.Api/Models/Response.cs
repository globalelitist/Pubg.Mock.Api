using Pubg.Api.Models.Included;
using Pubg.Api.Models.Match;

namespace Pubg.Api.Controllers
{
    public class Response
    {
        public Match[] Data { get; set; }

        public object[] Errors { get; set; }

        public object Links { get; set; } = new { };

        public IncludedResource[] Included { get; set; }

        //Not used
        public object Meta { get; set; } = new { };
    }
}
