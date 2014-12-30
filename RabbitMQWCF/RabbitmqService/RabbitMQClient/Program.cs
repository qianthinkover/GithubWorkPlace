using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RabbitMQClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart s = new ThreadStart(ReadMsg);
            s.Invoke();
            Console.Read();
        }
        static void ReadMsg()
        {
            while (true)
            { 
                using(RabbitMQWebServiceUsing.RabbitMQServiceClient client =new RabbitMQWebServiceUsing.RabbitMQServiceClient ())
                {
                    RabbitMQWebServiceUsing.RabbitMQBizInfo bizInfo = new RabbitMQWebServiceUsing.RabbitMQBizInfo();
                    string msg = client.ReceieveRabbitMQMsg(bizInfo);
                    if (string.IsNullOrEmpty(msg))
                        Thread.Sleep(1000);
                    else
                        Console.WriteLine("receieve msg : "+msg);
                }
            }
        }
    }
}
