using Pubg.Api.Models;
using Pubg.Api.Models.Included;

namespace Pubg.Api.Generators
{
    public static class ResponseGenerator
    {
        public static Response GenerateResponse(int teamSize = 2, string shardId = "pc-eu")
        {
            var response = new Response();

            int playerAmount = 100,
                participantAmount = 100,
                rosterAmount = playerAmount / teamSize;

            response.Included = new IncludedResource[playerAmount + participantAmount + rosterAmount];

            int i = 0;
            do
            {
                response.Included[i++] = GeneratePlayer(shardId);
            }
            while (i < playerAmount);

            do
            {
                response.Included[i++] = GenerateParticipant(shardId);
            }
            while (i < playerAmount + participantAmount);

            do
            {
                response.Included[i++] = GenerateRoster(shardId);
            }
            while (i < playerAmount + participantAmount + rosterAmount);

            return response;
        }

        private static IncludedResource GenerateRoster(string shardId)
        {
            return new IncludedResource
            {
                Type = "roster",
                Attributes = new RosterAttributes(shardId)
            };
        }

        private static IncludedResource GeneratePlayer(string shardId)
        {
            return new IncludedResource
            {
                Type = "player",
                Attributes = new PlayerAttributes(shardId)
            };
        }

        private static IncludedResource GenerateParticipant(string shardId)
        {
            return new IncludedResource
            {
                Type = "participant",
                Attributes = new ParticipantAttributes(shardId)
            };
        }
    }
}
