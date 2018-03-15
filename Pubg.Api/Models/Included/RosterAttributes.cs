namespace Pubg.Api.Models.Included
{
    public class RosterAttributes : IncludedAttribute
    {
        public RosterStats Stats { get; set; }

        public string Won { get; set; } = "false";
    }

    public class RosterStats
    {
        public int Rank { get; set; } = 23;

        public int TeamId { get; set; } = 28;
    }
}
