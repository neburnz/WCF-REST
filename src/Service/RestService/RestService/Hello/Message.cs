using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RestService.Hello
{
    [DataContract]
    public class Message
    {
        [DataMember]
        public string Text { get; set; }
    }
}