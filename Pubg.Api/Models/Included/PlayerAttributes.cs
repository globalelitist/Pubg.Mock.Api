namespace Pubg.Api.Models.Included
{
    public class PlayerAttributes : IncludedAttribute
    {
        public PlayerAttributes(string shardId) : base(shardId) { }

        public string Name { get; set; } = "Cc7698";

        public string PatchVersion { get; set; } = "";

        public object Stats { get; set; }

        public string TitleId { get; set; } = "bluehole-pubg";
    }
}