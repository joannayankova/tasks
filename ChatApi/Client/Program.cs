using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ServiceReference1;

namespace Client
{
    class Program
    {
        static void Main(string[] args)

        {
            //Step 1: Create an instance of the WCF proxy.
            ServiceClient client = new ServiceClient();

            string Message = Console.ReadLine();

            var kyr =client.RecieveMessage(Message);

            //Console.WriteLine(kyr);



            //Step 3: Closing the client gracefully closes the connection and cleans up resources.
            client.Close();
            Console.ReadLine();
        }
    }
}

