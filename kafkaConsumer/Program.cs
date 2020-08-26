using ConsoleApp1.Confluent;
using ConsoleApp1.kafka_net;
using KafkaNet;
using KafkaNet.Model;
using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //KafkaNetConsumer.StartConsumer();
            ConfluentConsumer consumer = new ConfluentConsumer();
            consumer.SubscribeAsync("test-topic", Console.WriteLine);
        }
    }
}
