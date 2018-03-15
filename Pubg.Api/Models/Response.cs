using Pubg.Api.Models.Included;

namespace Pubg.Api.Models
{
    public class Response
    {
        public object[] Data { get; set; }

        public object[] Errors { get; set; }

        public object Links { get; set; } = new { };

        public IncludedResource[] Included { get; set; }

        //Not used
        public object Meta { get; set; } = new { };
    }
}
