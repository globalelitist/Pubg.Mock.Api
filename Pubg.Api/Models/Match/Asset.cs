using System;

namespace Pubg.Api.Models.Match
{
    public class Asset
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Type => "asset";
    }
}