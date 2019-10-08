## Add Eventhub to Fruit App

1. Open your fruit console application that you created. 

2. We need to install the EventHub nuget package.
   a. Go to Tools > Nuget Package Manager > Package Manager Console. 
   b. Copy and paste this into the console 
   
   ```ps
   Install-Package Microsoft.Azure.EventHubs 
   ```
   c. Press return.
   d. Wait for the console to return package installed succesfully. This will allow us to serialize the fruit object as JSON. 

3. At the top of your Program.cs file, where you can see the using statements, add the following:

```c#
using Microsoft.Azure.EventHubs;
```

4. Where it says class Program in the Program.cs file, add the following code.

```c#
    class Program
    {
        private static EventHubClient eventHubClient;
```

5. After the RandomWait method you have already created, add the following code. 

```c#
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
```

6. At the start of the Main method, add the following, which will send the serialized message to the event hub.
* Copy the whole connehub string value from your fruitsend shared access policy of your eventhub, e.g. 

![Fruit Eventhub Messages](Images/SASConnString.PNG)

which when pasted in should look something like the following.

```c#
        static void Main(string[] args)
        {
            string connfruitehub = "Endpoint=sb://grifffruitehubns.servicebus.windows.net/;SharedAccessKeyName=fruitsend;SharedAccessKey=XXXXXXXXXXXXXX;EntityPath=fruitehub";
            string fruitehubname = "fruitehub";
```

7. You now need to send your message to the event hub by adding the wrapper to the try component of your Main method as per below.


```c#
                try
                {
                    string a = GetRandomColour(true);
                    Fruit fruit = new Fruit(a);
                    var message = JsonConvert.SerializeObject(fruit);                 //Remember Install-Package Newtonsoft.Json
                    WaitRandom();
                    Console.WriteLine(message);
                    EventHubWrapper(connfruitehub, fruitehubname, message).GetAwaiter().GetResult();  
                }
```

8. Run you console app and confirm that the messages are being sent to the console.

9. While running, navigate to your eventhub and confirm that messages are being received. This may take 2-5 minutes for the Azure Portal graphs to display that it is receiving messages, so be patient :). 

![Fruit Eventhub Messages](Images/FruitEventhubMessages.PNG)

[Back to ReadMe](../../../ReadMe.md)
