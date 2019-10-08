## Create Azure SQL DB

You might want to create the Azure SQL database using the portal the first time you do it just to a graphical understanding of how the resources are put together. After this initial deployment it is recommended you use an ARM template so you can repeat it more easily and consistently. 

* [Create in Azure Portal](#Create-in-Azure-Portal)
* [Create with ARM Template](###Create-with-ARM-Template)

### Create in Azure Portal

1. Navigate to the [Azure Portal](https://portal.azure.com) and go to your fruitdemo-rg resource group. 

2. Create a new resource in your fruitdemo-rg resource group.

![Create Resource](Images/CreateNewResource.PNG)

3. Create an Azure SQL resource.

![Create Azure SQL](Images/CreateAzureSQL.PNG)

4. Choose to create a single database.

![Create Single Database](Images/CreateSingleDatabase.PNG)

5. Set the basic settings:
* Ensure your required subscription is selected.
* Choose your fruitdemo-rg resource group.
* Set the database name to be Fruit. 
* Create new server...
  * Give it a unique name e.g. {yourname}-fruit-sql
  * Create an admin user e.g. {yourname}admin
  * Set a password. **Remember this password as we will be using it later to stream the data in the next step.**
  * Ensure the location is the same as your other resources, North Europe. 
  * Click OK on your server settings. 

![Create SQL Server](Images/CreateSQLDB.PNG)

6. Click configure database settings. 

![Configure Database](Images/ClickConfigureDB.PNG)

7. Choose "looking for basic, standard, premium" at the top. We are going to use Basic DTU pricing for this demo just to keep it simple.  
![Choose Basic Pricing](Images/ChooseBasicPricing.PNG)

8. Choose basic tier.  

![Choose Basic Tier](Images/ChooseBasicTier.PNG)

9. Apply basic tier.  

![Apply Basic Tier](Images/ApplyBasic.PNG)

10. Click review and create.

![Review and Create](Images/ReviewAndCreate.PNG)

11. Check your final settings and then click Create.

![Review and Create](Images/CreateSQLDBFinal.PNG)

12. It will take a few minutes to deploy, then navigate to your fruitdemo-rg and you will now see your azure sql resource. 

### Create with ARM Template

