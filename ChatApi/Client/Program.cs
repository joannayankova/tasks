using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Client.ServiceReference1;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ServiceClient client = new ServiceClient();

            Console.WriteLine("enter end to exit");
            while (true)
            {
                string Message = Console.ReadLine();
                if (Message == "end") break;

                var kyr = client.RecieveMessage(Message);
            }
            client.Close();
            Console.ReadLine();
        }
    }
}

