# Overview - Streaming Data Workshop

We are going to create an application that submits a colour and receives back a fruit. 
This will be a console application in C# that just loops and generates a number of fruit events until we cancel the application. These fruit events will generate a JSON message that we can send to an event hub. Using the event hub and azure stream analytics we will stream real time data to a data lake, a real time dataset in Power BI and also an Azure SQL DB. 

1. [Create Fruit Console App](Griffless/Instructions/01_CreateConsoleApp/CreateConsoleApp.md)
1. [Add Log and Error Handling](Griffless/Instructions/02_AddLogAndErrorHandling/AddLogAndErrorHandling.md)
1. [Create Data Lake](Griffless/Instructions/03_CreateDataLake/CreateDataLake.md)
1. [Create Event Hub](Griffless/Instructions/04_CreateEventHub/CreateEventHub.md)
1. [Add Event Hub To App](Griffless/Instructions/05_AddEventHubToApp/AddEventhubToApp.md)
1. [Create Stream To Lake](Griffless/Instructions/06_CreateStreamToLake/CreateStreamToLake.md)
1. [Create Stream Case Statement](Griffless/Instructions/07_StreamQueryCaseStatement/StreamQueryCaseStatement.md)   
1. [Create Stream To Power BI](Griffless/Instructions/08_CreateStreamToPowerBI/CreateStreamToPowerBI.md)   
1. [Create Azure SQL DB](Griffless/Instructions/09_CreateAzureSQLDB/CreateAzureSQLDB.md)   
1. [Create Stream To Azure SQL DB](Griffless/Instructions/10_CreateStreamToAzureSQLDB/CreateStreamToAzureSQLDB.md)   

### Pre-Requisites

* [Azure](https://portal.azure.com) Account - [Free Azure Trial](https://azure.microsoft.com/en-gb/free/search/?&OCID=AID719823_SEM_VNyprj9x&lnkd=Google_Azure_Brand&dclid=CjgKEAjw583nBRC33OzE0aaQvEoSJAAVMMJIS9V5KT7PZgtP2F7cgqJ6CObTA6VmZJ6_580FqRxOf_D_BwE)
* [Power BI](https://app.powerbi.com/home) Account - [Sign Up Here](https://powerbi.microsoft.com/en-us/landing/signin/)
* [Visual Studio Installed](https://visualstudio.microsoft.com/downloads/)
* [Visual Studio Azure Data Lake and Stream Analytics](https://marketplace.visualstudio.com/items?itemName=ADLTools.AzureDataLakeandStreamAnalyticsTools)

### Useful Links

* [ARM File Not Found Fix](https://omgdebugging.com/2017/08/14/adding-azure-arm-template-files-in-visual-studio-correctly/)
* [Querying JSON in Streaming](https://docs.microsoft.com/en-gb/azure/stream-analytics/stream-analytics-parsing-json)
