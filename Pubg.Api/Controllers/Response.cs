namespace Pubg.Api.Controllers
{
    public class Response
    {
        public object Data { get; set; }

        public object[] Errors { get; set; }

        public object Links { get; set; } = new { };

        public object Included { get; set; } = new { };

        //Not used
        public object Meta { get; set; } = new { };
    }
}
