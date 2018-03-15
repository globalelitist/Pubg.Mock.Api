using System;

namespace Pubg.Api.Models
{
    public class Status
    {
        public string Id => Guid.NewGuid().ToString();

        public string Type => "status";

        public object Attributes => new
        {
            ReleasedAt = DateTime.Now.ToString(),
            Version = ""
        };
    }
}
