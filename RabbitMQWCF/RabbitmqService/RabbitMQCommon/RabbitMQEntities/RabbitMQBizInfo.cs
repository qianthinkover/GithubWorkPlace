using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQCommon.RabbitMQEntities
{
    [DataContract]
    public class RabbitMQBizInfo
    {
         [DataMember]
        public string BizKey { get; set; }
         [DataMember]
        public string BizDescribe { get; set; }
    }
}
