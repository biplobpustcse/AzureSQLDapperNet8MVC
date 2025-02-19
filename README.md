# .Net 8 MVC application with Azure SQL and Dapper

## Create an Azure SQL Database

Step 1 If you don't have an Azure subscription, create an Azure free account before you begin.

Step 2 Sign in to the Azure portal with your Azure account.

Step 3 From the Azure portal menu, or from the Home page, select Create a resource
![image](https://github.com/user-attachments/assets/1f8c5120-fbb5-44c1-9130-9016b610f0b6)

Step 4 On Azure portal in the Search box, enter SQL Database. From the results list, choose SQL Databases.
![image](https://github.com/user-attachments/assets/f430430a-ad11-4a3c-8350-a37729de9471)

Step 5 On the SQL Database section, choose Create SQL Database.
![image](https://github.com/user-attachments/assets/0961910c-596e-4016-adc1-307965d544a5)

Step 6 On the Create SQL Database section provide the following information:
![image](https://github.com/user-attachments/assets/3d85d0b6-3be2-4733-9c8a-cce63c2cbaa7)

#### Set server firewall
![image](https://github.com/user-attachments/assets/25454096-0b11-4e15-8f59-a85bd38fdf41)

![image](https://github.com/user-attachments/assets/4f11eb35-f3a3-41d3-8c6b-5251ef8f9da5)

Here we add the current client IP address because we will need this to connect to this database from our local machine.

#### Create Database Table in Azure SQL
![image](https://github.com/user-attachments/assets/3baed0fd-7f9a-4ecf-9277-379277cc98e7)

Enter the following query in the Query editor pane.
```
Create table Companies
(
Id int primary key identity(1,1),
CompanyName nvarchar(150),
CompanyAddress nvarchar(250),
Country nvarchar(150),
GlassdoorRating int
)
```
Get Connection String from Azure SQL Database
![image](https://github.com/user-attachments/assets/a7207abc-3cb7-460d-a2c2-c8f2176e20fb)

Creating a New Project in Visual Studio
![image](https://github.com/user-attachments/assets/599e4296-c8d1-4ece-970b-5b7395e1e574)
