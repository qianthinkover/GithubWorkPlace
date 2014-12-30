using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQUntil.RabbitMQEntities
{
    [DataContract]
    public class QueueEntity
    {
           [DataMember]
        public int memory { get; set; }
           [DataMember]
        public int messages { get; set; }
           [DataMember]
        public int messages_ready { get; set; }
           [DataMember]
        public int messages_unacknowledged { get; set; }
           [DataMember]
        public string idle_since { get; set; }
           [DataMember]
        public string consumers { get; set; }
           [DataMember]
        public string state { get; set; }
           [DataMember]
        public string name { get; set; }
           [DataMember]
        public string vhost { get; set; }
           [DataMember]
        public bool durable { get; set; }
           [DataMember]
        public bool auto_delete { get; set; }
           [DataMember]
        public string node { get; set; }
    }
}
