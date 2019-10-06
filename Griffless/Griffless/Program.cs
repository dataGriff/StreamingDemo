using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Azure.EventHubs;
using System.Text;
using FruitConsole;
using System.Net;

namespace Griffless
{
    class Program
    {
        private static EventHubClient eventHubClient;

        static void Main(string[] args)
        {
            string connfruitehub = "Endpoint=sb://grifffruitehubns.servicebus.windows.net/;SharedAccessKeyName=fruitsend;SharedAccessKey=fFh5+RxebdvKMSk+/bx6suOMCtQQkheEGw+DhWwAIBk=;EntityPath=fruitehub";
            string fruitehubname = "fruitehub";

            while (1 == 1)
                {
                try
                {
                    string a = GetRandomColour(true);
                    Fruit fruit = new Fruit(a);
                    var message = JsonConvert.SerializeObject(fruit);                 //Remember Install-Package Newtonsoft.Json
                    WaitRandom();
                    Console.WriteLine(message);
                    EventHubWrapper(connfruitehub, fruitehubname, message).GetAwaiter().GetResult();  
                }
                catch (ColourException e)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    var error = JsonConvert.SerializeObject(e);
                    Console.WriteLine(error);
                    Console.ResetColor();
                    //string ehubname = "errorehub";
                    //EventHubWrapper(connehub, ehubname, error).GetAwaiter().GetResult();
                }
            }
        }

        public static string GetRandomColour(bool errorEnabled)
        {
            string randomColour;
            Array values = Enum.GetValues(typeof(Colour.Name));
            Random random = new Random();
            Colour.Name colour = (Colour.Name)values.GetValue(random.Next(values.Length));
            randomColour = colour.ToString();
            if (errorEnabled)
                {
                    ThrowRandomError(randomColour);
                }
            return randomColour;
        }

        public static void WaitRandom()
        {
            Random random = new Random();
            int randomWait = random.Next(0, 1000);
            System.Threading.Thread.Sleep(randomWait);
        }

        public static void ThrowRandomError(string colour)
        {
            Random random = new Random();
            int randomNum = random.Next(0, 10);
            if (randomNum == 1)
            {
                string message = "This is a random error for the colour " + colour + "!";
                throw new ColourException(message, colour);
            }
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
