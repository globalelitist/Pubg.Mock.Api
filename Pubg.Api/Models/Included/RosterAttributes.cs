namespace Pubg.Api.Models.Included
{
    public class RosterAttributes : IncludedAttribute
    {
        public RosterAttributes(string shardId) : base(shardId) { }

        public RosterStats Stats { get; set; } = new RosterStats();

        public string Won { get; set; } = "false";
    }

    public class RosterStats
    {
        public int Rank { get; set; } = 23;

        public int TeamId { get; set; } = 28;
    }
}
