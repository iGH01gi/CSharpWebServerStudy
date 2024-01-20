using HelloEmpty.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloEmpty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public List<HelloMessage> Get()
        {
            List<HelloMessage> messages = new List<HelloMessage>();
            messages.Add(new HelloMessage { Message = "Hello API 1" });
            messages.Add(new HelloMessage { Message = "Hello API 2" });
            messages.Add(new HelloMessage { Message = "Hello API 3" });

            return messages;
        }
    }
}
