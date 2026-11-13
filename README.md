# Smart Asset Tracking System

Smart Asset Tracking System program for handling assets with categories.
Written in c# using entity framework to store the data.
The program allows users to add, delete, edit, remove and view assets.

This program was witten to dig into some of the inner workings of entity framework core.

To make the code more maintainable and extensible, we can use inheritance to create a class hierarchy for different types of assets. The base class `Asset` will contain common properties such as `Brand` and `Model`, while derived classes will represent specific asset types like `Laptop`, `DesktopComputer`, `Samsung`, `IPhone`, `Nokia`, and `Tablet`.

## Class Diagram

```p
Asset (Base class) with Brand and Model properties
	- ComputerAsset
		- Laptop
		- Desktop
	- MobileAsset
		- Smartphone
		- Tablet
		- Samsung
		- IPhone
```

## The solution of the challange

For this we have to use the Entity Framework Core's Table Per Hierarchy (TPH) inheritance strategy. This allows us to store all asset types in a single table while differentiating them using a discriminator column.

```p
  protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.Entity<Asset>()
		.HasDiscriminator<string>("AssetType")
        .HasValue<Laptop>("Laptop")
        .HasValue<DesktopComputer>("DesktopComputer")
        .HasValue<Samsung>("Samsung")
        .HasValue<IPhone>("IPhone")
        .HasValue<Nokia>("Nokia")
        .HasValue<Tablet>("Tablet");
```

## How it works in the database

It creates a single table called `Assets` in the database with the following columns:
```p
[Id]
[Brand]
[Model]
[AssetType]
```

The column AssetType stores the name of the inherited class so entity frame work knows there it belongs. 

Then we seed the database with some initial data for each asset type using the `UseSeeding` method in the `OnConfiguring` method of the `MyDbContext` class we get the following data.
```p
Id	Brand	Model	    AssetType
1	HP	    Elitebook	Laptop
2	Dell	Latitude	Laptop
3	NULL	S26	        Samsung
```
The laptop class is not brand specific so it can handle both Brand and Model.  
Then we create a Samsung we already know it is a Samsung because it uses the Samsung derivate class, therefor the we do not need any data in the Brand column.

## Installation

Download the source code from the GitHub repository.
https://github.com/Spacebearswe/Smart-Asset-Tracking-System

## Setting up the project
```p
This project is built using .NET 10.0. To set up the project, follow these steps: 
1. Install .NET 10.0 SDK from the official .NET website.
2. Clone the repository to your local machine.
3. Open the project in your preferred IDE (e.g., Visual Studio, Visual Studio Code).
4. Restore the project dependencies.
5. The program is using Entity Framework, ensure that you have the necessary database setup and connection strings configured in the appsettings.json file.
6, If you need, then install the required NuGet packages for Entity Framework and     any other dependencies.
   For CLI use dotnet add package
   For NuGet Package Manager Console use Install-Package
   Microsoft.EntityFrameworkCore.SqlServer -v 10.0.15
   Microsoft.EntityFrameworkCore.SqlServer -v 10.0.15
   Microsoft.EntityFrameworkCore -v 10.0.15
   Microsoft.EntityFrameworkCore.Design -v 10.0.15
   Microsoft.EntityFrameworkCore.Tools -v 10.0.15
6. Update the database connection string in the MyDbContext.cs file to point to       your local database server.
7. Run Update-Database to create the database schema.
8. Build the project to ensure everything is set up correctly.
```

## Seeding the database
Update-Database also seeds the database with the initial data for each asset type.
If you want to reseed the database, you can use the following command in the
Package Manager Console:
```p
Update-Database -Force
```

## Usage

```p
Enter assets into the console, and the program will manage the list of assets
for you.
You can add, delete, edit, remove, view the assets.
The assets are stordes in a database
```
```p
Smart Asset Tracking System

Enter a Number
1-Add an Asset
2-Search an Asset
3-List Assets
4-Remove Asset
5-Update Asset
0-Quit
Enter a Number
```

## Contributing

Pull requests are welcome. For major changes, please open an issue first
to discuss what you would like to change.

Please make sure to update the database with migrations as changes occur appropriately.
Migrations can be added using the following command in the Package Manager Console:
```p
Add-Migration MigrationName
```
Create the database with the new migration using the following command in the Package Manager Console:
```p
Update-Database
```
## License

[MIT](https://choosealicense.com/licenses/mit/)
