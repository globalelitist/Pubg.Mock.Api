using System;

namespace Pubg.Api.Models
{
    public class Match : Resource
    {

        public DateTime CreatedAt { get; set; }

        public int Duration { get; set; }

        public Roster[] Rosters { get; set; }

        public string Rounds { get; set; }

        public Asset[] Assets { get; set; }

        public Participant[] Spectators { get; set; }

        public string GameMode { get; set; }

        public string PatchVersion { get; set; }

        public string TitleId { get; set; }

        public string Tags { get; set; }
    }
}
