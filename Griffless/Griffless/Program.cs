using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Azure.EventHubs;
using System.Text;

namespace Griffless
{
    class Program
    {
        private static EventHubClient eventHubClient;

        static void Main(string[] args)
        {
            while (1 == 1)
                {
                string a = GetRandomColour();
                Fruit fruit = new Fruit(a);
                var message = JsonConvert.SerializeObject(fruit);                 //Remember Install-Package Newtonsoft.Json
                WaitRandom();
                Console.WriteLine(message);
                string connehub = "Endpoint=sb://fruitehubns.servicebus.windows.net/;SharedAccessKeyName=fruitsas;SharedAccessKey=i0DRGLkbSIo7OkJRtLSGuOsPv6kiui7RbXcr6ERZUoY=;EntityPath=fruitehub";
                string ehubname = "fruitehub";
                   EventHubWrapper(connehub, ehubname, message).GetAwaiter().GetResult();
            }
        }

        public static string GetRandomColour()
        {
            Array values = Enum.GetValues(typeof(Colour.Name));
            Random random = new Random();
            Colour.Name randomColour = (Colour.Name)values.GetValue(random.Next(values.Length));
            return randomColour.ToString() ;
        }

        public static void WaitRandom()
        {
            Random random = new Random();
            int randomWait = random.Next(0, 1000);
            System.Threading.Thread.Sleep(randomWait);
        }

        
        private static async Task EventHubWrapper(string connectionString, string hubName, string message)
        {
         
            var connectionStringBuilder = new EventHubsConnectionStringBuilder(connectionString)    //Install-Package Microsoft.Azure.EventHubs
            {
                EntityPath = hubName
            };

            eventHubClient = EventHubClient.CreateFromConnectionString(connectionStringBuilder.ToString());

            await SendMessageToEventHub(message);

            await eventHubClient.CloseAsync();
        }

        private static async Task SendMessageToEventHub(string message)
        {
            await eventHubClient.SendAsync(new EventData(Encoding.UTF8.GetBytes(message)));
        }
        
    }
}
