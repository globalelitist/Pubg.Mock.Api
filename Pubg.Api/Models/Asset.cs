using System;

namespace Pubg.Api.Models
{
    public class Asset : Resource
    {
        public string TitleId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Filename { get; set; }

        public string ContentType { get; set; }

        public string URL { get; set; }
    }
}