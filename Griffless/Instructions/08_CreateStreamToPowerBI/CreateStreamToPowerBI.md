
# Create Stream to Power BI

1. If not stopped already, stop your stream analytics job.

1. Go your stream analytics job and a new Power BI Output called "FruitReport".

![Fruit Stream Output Report](Images/FruitStreamOutputReport.PNG)

3. Enter the details as below and authorize to your Power BI account.

![Fruit Stream Output Report Detail](Images/FruitStreamOutputReportDetail.PNG)

4. Amend your stream analytics query to include the following code:

```sql
SELECT
    [name] AS FruitName
    ,COUNT(*) AS FruitCount
INTO
    [fruitreport]
FROM
    [fruitstream]
WHERE [standardLog].[LogCode] = 1 --successful fruit send
GROUP BY 
    [name],
    SlidingWindow(second,10)
```
![Fruit Stream Query Report](Images/FruitStreamQueryReport.PNG)

5. If you don't have it running, start your FruitConsole app.

6. Start your stream analytics job.

![Fruit Stream Start](Images/FruitStreamStart.PNG)

7. Go to your [Power BI Account](https://app.powerbi.com/home).

![Power BI Home](Images/PowerBIHome.PNG)

8. Go to your workspace. 

9. Go to datasets and (eventually) you will see a "Fruit" dataset.

![PowerBI Fruit Dataset](Images/PowerBIFruitDataset.PNG)

10. Create a new dashboard.

![PowerBI Dashboard Create](Images/PowerBIDashboardCreate.PNG)

![PowerBI Dashboard Create Name](Images/PowerBIDashboardCreateName.PNG)

11. Add a real time tile to your dashboard.

![PowerBI Add Tile Real Time Data](Images/PowerBIAddTileRealTimeData.PNG)

12. Select your fruit dataset. 

![PowerBI Fruit Dataset Select](Images/PowerBIFruitDatasetSelect.PNG)


13. Enter the details of the fields to use in your tile as below. Use a card visualisation and use FruitCount as your field. 

![PowerBI Card Fields](Images/PowerBICardFields.PNG)

14. Set your title to be "Total Fruit Count Last 10 Seconds" and click apply.

![PowerBI Card Title](Images/PowerBICardTitle.PNG)

15. Expand your tile so that the title fits.

![PowerBI Tile Expand](Images/PowerBITileExpand.PNG)

16. Add another tile using your fruit streaming dataset.

17. Choose clustered bar chart as your visualsation, use fruitname as your axis and fruitcount as your value.

![PowerBI Bar Chart](Images/PowerBIBarChart.PNG)

18. Set your title to be "Fruit Count Last 10 Seconds" and click apply.

![PowerBI Bar Chart Title](Images/PowerBIBarChartTitle.PNG)

19. You should end up with a moving real time dashboard as below.

![PowerBI Dashboard](Images/PowerBIDashboard.PNG)

[Back to ReadMe](../../../ReadMe.md)
