using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatApi
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface IService
    {
        [OperationContract]
        string RecieveMessage(string message);
        
      
    }
}
