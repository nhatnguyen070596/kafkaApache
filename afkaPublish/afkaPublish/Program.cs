using afkaPublish;

Console.WriteLine("Hello!, This is my Kafka Producer Application");
ProduceMessage produceMessage = new ProduceMessage();
produceMessage.CreateMessage().Wait();