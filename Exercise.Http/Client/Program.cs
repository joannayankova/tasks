using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "api/create-message");

                HttpRequestMessage requestGet = new HttpRequestMessage(HttpMethod.Get, "api/creaste-message");
                HttpRequestMessage requestGet1 = new HttpRequestMessage(HttpMethod.Get, "api/get-all");

                //for(int i=0;i<10;i++)
                Message[] mesages = new Message[10];
                
                for(int i=0;i<mesages.Length;i++)
                {
                    mesages[i].id = int.Parse(Console.ReadLine());
                    mesages[i].sender = (Console.ReadLine());
                    mesages[i].body = (Console.ReadLine());
                }
                var jsonBody = JsonConvert.SerializeObject(mesages, Formatting.Indented, new JsonSerializerSettings());


                request.Content = new StringContent(jsonBody, System.Text.Encoding.UTF8, "application/json");
                request.Headers.Add("Accept", "application/json");
                HttpResponseMessage a = client.SendAsync(request).Result;


                var jsonBody1 = JsonConvert.SerializeObject(5, Formatting.Indented, new JsonSerializerSettings());
                requestGet.Content = new StringContent(jsonBody1, System.Text.Encoding.UTF8, "application/json");
                requestGet.Headers.Add("Accept", "application/json");
                HttpResponseMessage a = client.GetAsync(requestGet).Result;

            }
        }

        public class Message
        {
            public int id{ get; set; }
            public string sender { get; set; }
            public string body { get; set; }
        }
    }
}
