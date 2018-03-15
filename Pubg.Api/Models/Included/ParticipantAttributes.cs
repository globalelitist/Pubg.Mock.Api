using System;

namespace Pubg.Api.Models.Included
{
    public class ParticipantAttributes : IncludedAttribute
    {
        public ParticipantAttributes(string shardId) : base(shardId) { }

        public string Actor { get; set; } = "";

        public ParticipantStats Stats { get; set; }
    }
}
