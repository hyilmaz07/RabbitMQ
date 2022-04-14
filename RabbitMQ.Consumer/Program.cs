using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace RabbitMQ.Consumer
{
    class Program
    {
        private static string connectionString = "amqp://admin:123456@192.168.10.14:5672";
        private static string QueueName;
        private static IModel _channel;
        private static IModel channel => _channel ?? (_channel = CreateOrGetChannel());
        private static IConnection connection;
        static void Main(string[] args)
        {
            QueueName = args.Length > 0 ? args[0] : "";
            connection = GetConnection();


            //test esnasında önce consumer açıldığı için hata vermesin diye buraya ekledim. aslında producer tarafından  yapılması gerekiyor. 
            channel.QueueDeclare(QueueName, exclusive: false, autoDelete: false);

            var consumerEvent = new EventingBasicConsumer(channel);
            consumerEvent.Received += ConsumerEvent_Received;

            //autoAck :  true olarak atanır ise, ilgili mesaj alındıktan sonra Queue’den otomatik olarak silinir.
            channel.BasicConsume(QueueName, autoAck: true, consumerEvent);

            Console.WriteLine($"{QueueName} listening...\n\n\n");
            Console.ReadLine();
        }

        private static void ConsumerEvent_Received(object sender, BasicDeliverEventArgs e)
        {
   
            string message = Encoding.UTF8.GetString(e.Body.ToArray());

            Console.WriteLine($"Received Data : {message}");
        }

        private static IModel CreateOrGetChannel()
        {
            return connection.CreateModel();
        }
        private static IConnection GetConnection()
        {
            ConnectionFactory factory = new ConnectionFactory()
            {
                Uri = new Uri(connectionString, uriKind: UriKind.RelativeOrAbsolute)
            };
            return factory.CreateConnection();
        }
    }
}
