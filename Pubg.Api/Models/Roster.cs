namespace Pubg.Api.Models
{
    public class Roster : Resource
    {

        public string Team { get; set; }

        public Participant[] Participants { get; set; }

        public string Won { get; set; }
    }
}