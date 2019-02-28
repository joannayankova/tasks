using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44339");

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "api/Message/create-message");

                List<Message> messages = new List<Message>();

                for (int i = 0; i < 10; i++)
                {
                    messages.Add(new Message(Guid.NewGuid().ToString(), "sender1", i.ToString()));
                }
                try
                {
                    var jsonBody = JsonConvert.SerializeObject(messages, new JsonSerializerSettings());
                    request.Content = new StringContent(jsonBody, System.Text.Encoding.UTF8, "application/json");
                    request.Headers.Add("Accept", "application/json");
                    HttpResponseMessage a = client.SendAsync(request).Result;


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //}}



                //HttpResponseMessage responseGet = client.GetAsync("http://localhost:44339/api/Message/get-message?id=5").Result;
                //HttpResponseMessage responsegetAll = client.GetAsync("http://localhost:44339/api/Message/get-all").Result;



            }
        }

        public class Message
        {
            public Message()
            {

            }

            public Message(string uuid, string sender, string body)
            {
                this.uuid = uuid;
                this.sender = sender;
                this.body = body;
            }

            public string uuid { get; set; }
            public string sender { get; set; }
            public string body { get; set; }
        }
    }
}
