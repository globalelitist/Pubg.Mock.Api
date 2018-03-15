namespace Pubg.Api.Models.Match
{
    public class MatchAttributes
    {

        public string CreatedAt { get; set; } = "2018-03-12T17:41:34Z";

        public int Duration { get; set; } = 1604;

        public string GameMode { get; set; } = "squad";

        public string PatchVersion { get; set; } = "";

        public object Stats { get; set; } = new { };

        public string ShardId { get; set; } = "pc-eu"; //EU BEST U

        public string TitleId { get; set; } = "bluehole-pubg";

        public object Tags { get; set; } = new { };//no idea
    }
}