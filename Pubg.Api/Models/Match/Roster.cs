using System;

namespace Pubg.Api.Models.Match
{
    public class Roster
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Type => "roster";
    }
}