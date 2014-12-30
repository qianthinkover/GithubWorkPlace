using RabbitMQUntil.RabbitMQEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQCommon
{
    public class RabbitMQBindUntil
    {
        public bool CheckBind(ExchangeEntity exchange, QueueEntity queue, string RouteKey)
        {
            return false;
        }
        /// <summary>
        /// 帮顶指定的交换机和消息队列
        /// </summary>
        /// <param name="exchange"></param>
        /// <param name="queue"></param>
        /// <param name="RouteKey"></param>
        /// <returns></returns>
        public bool RabbitMQBindExchangeAndQueue(ExchangeEntity exchange,QueueEntity queue,string RouteKey)
        {
            return false;   
        }
        /// <summary>
        /// 解绑指定的交换机和消息队列
        /// </summary>
        /// <param name="exchange"></param>
        /// <param name="queue"></param>
        /// <param name="RouteKey"></param>
        /// <returns></returns>
        public bool RabbitMQUnBindExchangeAndQueue(ExchangeEntity exchange, QueueEntity queue, string RouteKey)
        {
            return false;
        }

    }
}
