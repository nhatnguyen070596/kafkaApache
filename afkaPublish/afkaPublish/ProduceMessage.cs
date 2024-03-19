using System;
using Confluent.Kafka;

namespace afkaPublish
{
    public class ProduceMessage
    {
        public async Task CreateMessage(string topic)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:29092",
                ClientId = "my-app",
                BrokerAddressFamily = BrokerAddressFamily.V4,
            };

            using var producer = new ProducerBuilder<Null, string>(config).Build();

            Console.WriteLine("Please enter the message you want to send");
            var input = Console.ReadLine();

            var message = new Message<Null, string>
            {
                Value = input
            };

            var deliveryReport = await producer.ProduceAsync(topic, message);
            Console.WriteLine($"Message delivered to {deliveryReport.TopicPartitionOffset}");

        }
    }
}
}

