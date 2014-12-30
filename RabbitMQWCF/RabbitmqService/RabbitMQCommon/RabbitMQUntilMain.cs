using RabbitMQ.Client;
using RabbitMQCommon.RabbitMQEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RabbitMQCommon
{
    public class RabbitMQUntilMain
    {
        private ConnectionFactory factory;
        private bool msgIsDurable;
        private bool msgIsBiaoJi;
        private string exchangeName;
        private string messageRoutingKey;
        private string queueName;

        public RabbitMQUntilMain(RabbitMQBizInfo BizInfo)
        {
            this.factory = new ConnectionFactory()
            { 
                 HostName = "localhost"
            };
            this.msgIsDurable = true;
            this.exchangeName = "demo";
            this.queueName="demo";
            this.msgIsBiaoJi = true;
            this.messageRoutingKey = "demo";
        }

        public ConnectionFactory GetConnectionFactory()
        { 
            return this.factory;
        }
        
        public void SendMessage(string message)
        {
            using (IConnection connection = factory.CreateConnection())
            {
                using (IModel channel = connection.CreateModel())
                {
                    IBasicProperties properties = channel.CreateBasicProperties();
                    
                    properties.SetPersistent(msgIsDurable);

                    byte[] msgBody = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchangeName, messageRoutingKey, properties, msgBody);

                    Thread.Sleep(10);
                }
            }
        }
        public string ReceieveMessage()
        {
            string receieveMsg = string.Empty;
            using (IConnection connection = factory.CreateConnection())
            {
                using (IModel channel = connection.CreateModel())
                {
                    var s = new StringBuilder();
                    var q = channel.BasicGet(queueName , msgIsBiaoJi);
                    if (q != null)
                    {
                        string w = Encoding.UTF8.GetString(q.Body);
                        receieveMsg = w;
                    }
                }
            }
            return receieveMsg;
        }
    }
}
