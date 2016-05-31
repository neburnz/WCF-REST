using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace RestService.Hello
{
    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract]
        Message Greetings(Subject subject);
    }
}
