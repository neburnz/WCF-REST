using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace RestService.Hello
{
    public class HelloService : IHelloService
    {
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public Message Greetings(Subject subject)
        {
            return new Message() { Text = "Hello " + subject.Name };
        }
    }
}
