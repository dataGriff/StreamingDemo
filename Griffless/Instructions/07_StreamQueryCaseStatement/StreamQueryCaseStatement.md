# Create Query Case Statement

To demonstrate how easy it is to use stream analytics and its SQL-like language, we are going to add a case statement to our query to the data lake to get more categorical data in real-time.

* [Amend Query in Azure Portal](###Amend-Query-in-Azure-Portal)
* [Amend Query in Stream Analytics Project](###Amend-Query-in-Stream-Analytics-Project])

### Amend Query in Azure Portal

1. Go to your stream analytics job.

2. Stop the job.

3. Amend the query to have the code below:

```sql
SELECT
    *, CASE WHEN name = 'Banana' THEN 'Yes'
    ELSE 'No' END AS [FruitEatenByMonkeys]
INTO
    [fruitlake]
FROM
    [fruitstream]
```

![Fruit Stream Case Query](Images/FruitStreamCaseQuery.PNG)

4. Start your job.

![Fruit Stream Start](Images/FruitStreamStart.PNG)

5. Look in your data lake and see the new data for "FruitEatenByMonkeys". 

![Data Lake Fruit Eaten By Monkeys](Images/DataLakeFruitEatenByMonkeys.PNG)

[Back to ReadMe](../../../ReadMe.md)

### Amend Query in Stream Analytics Project

1. Go to your stream analytics job.

2. Stop the job.

3. In your stream analytics project, amend the query to be the below.

```sql
SELECT
    *, CASE WHEN name = 'Banana' THEN 'Yes'
    ELSE 'No' END AS [FruitEatenByMonkeys]
INTO
    [fruitlake]
FROM
    [fruitstream]
```

![VS Stream Case Query](Images/VSStreamCaseQuery.PNG)

4. Publish your stream job to Azure.

5. Start your job.

![Fruit Stream Start](Images/FruitStreamStart.PNG)

6. Look in your data lake and see the new data for "FruitEatenByMonkeys". 

![Data Lake Fruit Eaten By Monkeys](Images/DataLakeFruitEatenByMonkeys.PNG)

[Back to ReadMe](../../../ReadMe.md)
