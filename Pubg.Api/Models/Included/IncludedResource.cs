using System;

namespace Pubg.Api.Models.Included
{
    public class IncludedResource
    {
        public string Type { get; set; } = "participant";

        public string Id { get; set; } = Guid.NewGuid().ToString();

        public IncludedAttribute Attributes { get; set; }
    }
}