using KafkaNet;
using KafkaNet.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.kafka_net
{
    class KafkaNetConsumer
    {
        public static void StartConsumer()
        {
            string topic = "test-topic";
            Uri uri = new Uri("http://localhost:9092");
            var options = new KafkaOptions(uri);

            var router = new BrokerRouter(options);

            var consumer = new Consumer(new ConsumerOptions(topic, router));
            //consumer.SetOffsetPosition(new KafkaNet.Protocol.OffsetPosition(0, 10));

            while (true)
            {
                foreach (var message in consumer.Consume())
                {
                    Console.WriteLine(Encoding.UTF8.GetString(message.Value));
                }
            }
        }
    }
}
