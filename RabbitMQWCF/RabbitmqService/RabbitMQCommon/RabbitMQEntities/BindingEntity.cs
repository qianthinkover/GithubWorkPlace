using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQUntil.RabbitMQEntities
{
    [DataContract]
    public class BindingEntity
    {
         [DataMember]
        public string source { get; set; }
         [DataMember]
        public string vhost { get; set; }
         [DataMember]
        public string destination { get; set; }
         [DataMember]
        public string destination_type { get; set; }
        [DataMember]
        public string routing_key { get; set; }
        [DataMember]
        public string properties_key { get; set; }
    }
}
