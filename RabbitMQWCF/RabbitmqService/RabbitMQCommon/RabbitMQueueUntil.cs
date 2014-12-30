using RabbitMQUntil.RabbitMQEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQCommon
{
    public class RabbitMQueueUntil
    {
        public bool CreateQueue()
        {
            return false;
        }
        public bool DeleteQueue()
        {
            return false;
        }

        public List<QueueEntity> GetAllQueues()
        {
            return null; 
        }
    }
}
