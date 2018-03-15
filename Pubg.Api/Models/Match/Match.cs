using System;

namespace Pubg.Api.Models.Match
{
    public class Match
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public MatchAttributes Attributes { get; set; } = new MatchAttributes();

        public MatchLinks Links { get; set; } = new MatchLinks();

        public MatchRelationships Relationships { get; set; } = new MatchRelationships();

        public string Type => "match";
    }
}
