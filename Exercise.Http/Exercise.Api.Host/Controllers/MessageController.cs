using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Exercise.Api.Host.Controllers
{
    [Route("api/Message")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private static List<Message> messages = new List<Message>();

        [HttpPost, Route("create-message")]
        public void Post([FromBody] List<Message> messagesFromRequest)
        {
            foreach (var item in messagesFromRequest)
            {
                messages.Add(item);
            }
        }

        [HttpGet, Route("get-all")]
        public ActionResult<List<Message>> Get()
        {
            return messages;
        }

        [HttpGet, Route("get-message")]
        public ActionResult<Message> Get(string uuid)
        {
            return messages.FirstOrDefault(x => x.Uuid.Equals(uuid));
        }

        public class MyCustomObject
        {
            public List<Message> Messages { get; set; }
        }

        public class Message
        {
            public string Uuid { get; set; }
            public string Sender { get; set; }
            public string Body { get; set; }
        }
    }
}
