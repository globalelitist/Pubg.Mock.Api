using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pubg.Api.Models
{
    public class Status
    {
        public string Id => "pubg-api";

        public string Type => "status";

        public object Attributes => new
        {
            ReleasedAt = DateTime.Now,
            Version = "master"
        };
    }
}
