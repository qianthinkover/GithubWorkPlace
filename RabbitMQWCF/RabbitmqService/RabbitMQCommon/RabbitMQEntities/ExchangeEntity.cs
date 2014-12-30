using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQUntil.RabbitMQEntities
{
     [DataContract]
    public class ExchangeEntity
    {
          [DataMember]
        public MessageStatsEntity message_stats { get; set; }
          [DataMember]
        public string name { get; set; }
          [DataMember]
        public string vhost { get; set; }
          [DataMember]
        public string type { get; set; }
          [DataMember]
        public bool durable { get; set; }
          [DataMember]
        [JsonProperty("internal")]
        public bool internalFlag { get; set; }
          [DataMember]
        public bool auto_delete { get; set; }
    }

}
