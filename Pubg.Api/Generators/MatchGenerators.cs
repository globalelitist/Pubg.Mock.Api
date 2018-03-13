using Pubg.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pubg.Api.Generators
{
    public class MatchGenerator
    {

        private string _shardId;
        private int _teamSize;

        public MatchGenerator(int teamSize = 2)
        {
            _shardId = Guid.NewGuid().ToString();
            _teamSize = teamSize;
        }

        public Match GenerateMatch(string id = "")
        {
            id = string.IsNullOrWhiteSpace(id) ? Guid.NewGuid().ToString() : id;

            var match = new Match
            {
                Id = Guid.NewGuid().ToString(),
                CreatedAt = DateTime.Now,
                PatchVersion = "3.6.1",
                Duration = 30 * 60 * 100, //30 minutes?
                ShardId = _shardId,
                Assets = GenerateAssets(),
                Rosters = GenerateRosters()
            };

            return match;

        }

        private Asset[] GenerateAssets()
        {
            return new Asset[]
            {
                GenerateAsset()
            };
        }

        private Asset GenerateAsset()
        {
            return new Asset
            {
                Id = Guid.NewGuid().ToString(),
                ShardId = _shardId,
                CreatedAt = DateTime.Now,
                ContentType = "application/json",
                Filename = "telemetry.json",
                URL = "pubg.fake/telemetry.json",
                Name = "Telemetry"
            };
        }

        private Roster[] GenerateRosters()
        {
            var maxTeams = 100 / _teamSize;

            var rosters = new List<Roster>();

            for (int i = 0; i < maxTeams; i++)
            {
                rosters.Add(GenerateRoster(_teamSize));
            }

            rosters[0].Won = "Yes";

            return rosters.ToArray();
        }

        private Roster GenerateRoster(int teamSize)
        {
            var roster = new Roster
            {
                Id = Guid.NewGuid().ToString(),
                Participants = new Participant[teamSize],
                Won = "No",
                ShardId = _shardId,
                Stats = "Very good"
            };

            for (int i = 0; i < teamSize; i++)
            {
                roster.Participants[i] = GenerateParticipant();
            }

            return roster;
        }

        private Participant GenerateParticipant()
        {
            return new Participant
            {
                Id = Guid.NewGuid().ToString(),
                Stats = "Did some damage",
                ShardId = _shardId
            };
        }
    }
}
