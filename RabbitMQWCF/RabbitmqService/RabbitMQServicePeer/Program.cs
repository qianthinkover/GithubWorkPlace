using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQServicePeer
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Y";
            do
            {
                SendMsg();
                Console.WriteLine("是否继续发送");
                s = Console.ReadLine();
            } while (s.Equals("Y"));
            Console.Read();
        }
        static void SendMsg()
        {
            for (int i = 0; i < 10; i++)
            {
                RabbitMQServiceUsing.RabbitMQBizInfo bizInfo = new RabbitMQServiceUsing.RabbitMQBizInfo();
                RabbitMQServiceUsing.RabbitMQServiceClient client = new RabbitMQServiceUsing.RabbitMQServiceClient();
                client.PublishRabbitMQMsg(bizInfo, i.ToString());
                Console.WriteLine("sending to RabbitMQ server msg:" + i.ToString());
            }
        }
    }
}
