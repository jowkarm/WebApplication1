using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet(Name = "GetHelloWorld")]
        public string HelloWorld()
        {
            return "Hello World!";
        }
    }
}
