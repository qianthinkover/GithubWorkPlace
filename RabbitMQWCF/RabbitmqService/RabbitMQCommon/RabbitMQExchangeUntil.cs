using RabbitMQUntil.RabbitMQEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQCommon
{
    public class RabbitMQExchangeUntil
    {
        public bool CreateMQExchange()
        {
            return true;
        }
        public bool DeleteMQExchange()
        {
            return true;
        }

        public List<ExchangeEntity> GetAllExchages()
        {
            return null;
        }
    }
}
