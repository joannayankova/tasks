using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatApi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService
    {
        public string RecieveMessage(string message)
        {
            Console.WriteLine("Return: {0}", message);
            return message;
           
        }
       

   
    }
}
