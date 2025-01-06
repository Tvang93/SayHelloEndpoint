using Microsoft.AspNetCore.Mvc;

namespace SayHello.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHello : ControllerBase
    {
        public List<string> greetingsList = new();

        [HttpPost]
        [Route("AddGreeting/{userName}")]
        public List<string> AddGreeting(string userName)
        {
            greetingsList.Add($"Hello, {userName}!");
            return greetingsList;
        }
    }
}