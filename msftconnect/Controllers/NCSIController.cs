using Microsoft.AspNetCore.Mvc;

namespace msftconnect.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NCSIController : Controller
    {
        [HttpGet, Route("/ncsi.txt")]
        public ContentResult GetNCSI() => this.Content("Microsoft NCSI", "text/plain");

        [HttpGet, Route("/connecttest.txt")]
        public ContentResult GetConnect() => this.Content("Microsoft Connect Test", "text/plain");
    }
}
