# EfDbFirstExample
Example of using enttity framework database first

Nuget packages:\
Microsoft.EntityFrameworkCore\
Microsoft.EntityFrameworkCore.Design\
Microsoft.EntityFrameworkCore.SqlServer

From CLI (Azure Data Studio):\
dotnet ef dbcontext scaffold "Data Source=localhost,<port>; User Id=sa;Password=<password>; Initial Catalog=BikeStores" Microsoft.EntityFrameworkCore.SqlServer -o Model

LocalDb connection string: "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YourDatabase" 

Creates a DbContext named after the DB and Models
