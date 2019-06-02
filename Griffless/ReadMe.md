# Overview - Streaming Data Workshop

We are going to create an application that submits a colour and receives back a fruit. 
This will be a console application in C# that just loops and generates a number of fruit events until we cancel the application. These fruit events will generate a JSON message that we can send to an even hub. Using the event hub and data lake analytics we will stream real time data to a data lake, a real time dataset in Power BI and also an Azure SQL DB. 

1. [Create Fruit Console App](01_CreateConsoleApp.md)
1. [Create Data Lake](02_CreateDataLake.md)
1. [Create Event Hub](03_CreateEventHub.md)
1. [Create Stream To Lake](04_CreateStreamToLake.md)
1. [Create Stream To Power BI](05_CreateStreamToPowerBI.md)   
1. [Create Stream To Azure SQL DB](06_CreateStreamToAzureDB.md)   

### Pre-Requisites

* [Azure](https://portal.azure.com) Account - [Free Azure Trial](https://azure.microsoft.com/en-gb/free/search/?&OCID=AID719823_SEM_VNyprj9x&lnkd=Google_Azure_Brand&dclid=CjgKEAjw583nBRC33OzE0aaQvEoSJAAVMMJIS9V5KT7PZgtP2F7cgqJ6CObTA6VmZJ6_580FqRxOf_D_BwE)
* [Power BI](https://app.powerbi.com/home) Account - [Sign Up Here](https://powerbi.microsoft.com/en-us/landing/signin/)
* [Visual Studio Installed](https://visualstudio.microsoft.com/downloads/)

### Useful Links