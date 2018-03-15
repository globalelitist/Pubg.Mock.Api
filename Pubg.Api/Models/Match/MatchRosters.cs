using System;

namespace Pubg.Api.Models.Match
{
    public class MatchRosters
    {
        public Roster[] Data { get; set; } = new Roster[]
        {
            new Roster
            {
                Id = Guid.NewGuid().ToString()
            }
        };
    }
}