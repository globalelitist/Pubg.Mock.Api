namespace Pubg.Api.Models.Match
{
    public class MatchRelationships
    {
        public MatchAssets Assets { get; set; } = new MatchAssets();

        public MatchRosters Rosters { get; set; } = new MatchRosters();

        public MatchRounds Rounds { get; set; } = new MatchRounds();

        public object Spectators { get; set; } = new
        {
            data = new object[] { }
        };
    }
}
