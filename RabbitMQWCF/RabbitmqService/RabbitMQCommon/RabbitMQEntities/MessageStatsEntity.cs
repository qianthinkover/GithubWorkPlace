using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQUntil.RabbitMQEntities
{
    [DataContract]
    public class MessageStatsEntity
    {
          [DataMember]
        public int publish_in { get; set; }
         [DataMember]
        public PublishindetailsEntity publish_in_details { get; set; }
         [DataMember]
        public int publish_out { get; set; }
         [DataMember]
        public PublishoutdetailsEntity publish_out_details { get; set; }
    }

}
