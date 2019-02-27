using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        
        static void Main(string[] args)
        {
            client.PostAsync(" http://localhost:5000",content)
            ProcessRepositories().Wait();
        }

        private static async Task ProcessRepositories()
        {

        }
    }
}
