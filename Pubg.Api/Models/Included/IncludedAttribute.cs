namespace Pubg.Api.Models.Included
{
    public class IncludedAttribute
    {
        public IncludedAttribute(string shardId)
        {
            ShardId = shardId;
        }

        public string ShardId { get; set; } = "pc-eu";
    }
}