using Microsoft.AspNetCore.Mvc;
using System;

namespace Exercise.Host
{
    [Route("[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        [HttpGet, Route("getKyr")]
        public void Get()
        {
            Console.WriteLine("Kyr");
        }

        [HttpPost, Route("kyr")]
        public void Post(string value)
        {
            Console.WriteLine(value);
        }
    }
}
