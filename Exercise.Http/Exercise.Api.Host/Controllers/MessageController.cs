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
        [HttpPost]
        public Message[] Post([FromBody] Message[] message)
        {
            //spisuk
            foreach (var msg in message)
            {
                Console.WriteLine(msg.Id + ":" + msg.Sender + ":" + msg.Body);
            }

          
        }

        [HttpGet]
        public void Get([FromBody] Message[] message)
        {
            foreach (var msg in message)
            {
                msg.ShowDetails();
            }
            
        }

        [HttpGet("{id}")]
        public void Get(int id,Message[] messages)
        {
            messages[id].ShowDetails();
        }


        public class Message
        {
            public int Id { get; set; }
            public string Sender { get; set; }
            public string Body { get; set; }

            public void ShowDetails()
            {
                Console.WriteLine(this.Id + this.Sender + this.Body);

            }
         }



    

}
