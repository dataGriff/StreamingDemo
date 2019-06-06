
# Create Stream to Power BI

1. If not stopped already, stop your stream analytics job.

1. Go your stream analytics job and a new Power BI Output called "FruitReport".

![Fruit Stream Output Report](FruitStreamOutputReport.PNG)

3. Enter the details as below and authorize to your Power BI account.

![Fruit Stream Output Report Detail](FruitStreamOutputReportDetail.PNG)

4. Amend your stream analytics query to include the following code:

```sql
SELECT
    [name] AS FruitName
    ,COUNT(*) AS FruitCount
INTO
    [fruitreport]
FROM
    [fruit]
GROUP BY 
    [name],
    SlidingWindow(second,10)
```
![Fruit Stream Query Report](FruitStreamQueryReport.PNG)

5. Start your stream analytics job.
![Fruit Stream Start](FruitStreamStart.PNG)


6. Go to your [Power BI Account](https://app.powerbi.com/home).

![Power BI Home](PowerBIHome.PNG)

7. Go to your workspace. 

8. Go to datasets and (eventually) you will see a "Fruit" dataset.

![PowerBI Fruit Dataset](PowerBIFruitDataset.PNG)

9. Create a new dashboard.

![PowerBI Dashboard Create](PowerBIDashboardCreate.PNG)

![PowerBI Dashboard Create Name](PowerBIDashboardCreateName.PNG)

10. Add a real time tile to your dashboard.

![PowerBI Add Tile Real Time Data](PowerBIAddTileRealTimeData.PNG)

11. Select your fruit dataset. 

![PowerBI Fruit Dataset Select](PowerBIFruitDatasetSelect.PNG)


12. Enter the details of the fields to use in your tile as below. Use a card visualisation and use FruitCount as your field. 

![PowerBI Card Fields](PowerBICardFields.PNG)

13. Set your title to be "Total Fruit Count Last 10 Seconds" and click apply.

![PowerBI Card Title](PowerBICardTitle.PNG)

14. Expand your tile so that the title fits.

![PowerBI Tile Expand](PowerBITileExpand.PNG)

15. Add another tile using your fruit streaming dataset.

16. Choose clustered bar chart as your visualsation, use fruitname as your axis and fruitcount as your value.

![PowerBI Bar Chart](PowerBIBarChart.PNG)

17. Set your title to be "Fruit Count Last 10 Seconds" and click apply.

![PowerBI Bar Chart Title](PowerBIBarChartTitle.PNG)

18. You should end up with a moving real time dashboard as below.

![PowerBI Dashboard](PowerBIDashboard.PNG)