using Microsoft.AspNetCore.Mvc;

namespace msftconnect.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NCSIController(IConfiguration configuration) : Controller
    {
        [HttpGet, Route("/")]
        public ContentResult Get() => this.Content(configuration["DEF"] ?? "null", "text/plain");

        [HttpGet, Route("/ncsi.txt")]
        public ContentResult GetNCSI() => this.Content(configuration["NCSI"] ?? "Microsoft NCSI", "text/plain");

        [HttpGet, Route("/connecttest.txt")]
        public ContentResult GetConnect() => this.Content(configuration["Connecttest"] ?? "Microsoft Connect Test", "text/plain");
    }
}
