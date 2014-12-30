using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQUntil.RabbitMQEntities
{
    [DataContract]
    public class PublishoutdetailsEntity
    {
           [DataMember]
        public double rate { get; set; }
    }
}
