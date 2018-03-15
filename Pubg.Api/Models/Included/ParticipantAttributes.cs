using System;

namespace Pubg.Api.Models.Included
{
    public class ParticipantAttributes : IncludedAttribute
    {
        public string Actor { get; set; } = "";

        public ParticipantStats Stats { get; set; }
    }
}
