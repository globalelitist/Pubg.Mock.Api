using System;

namespace Pubg.Api.Models.Match
{
    public class MatchAssets
    {
        public Asset[] Data { get; set; } = new Asset[]
        {
            new Asset
            {
                Id = Guid.NewGuid().ToString()
            }
        };
    }
}