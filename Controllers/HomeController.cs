using Microsoft.AspNetCore.Mvc;

namespace basic_auth_example.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
