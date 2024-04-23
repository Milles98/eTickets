# eTickets MVC Project
### Overview

eTickets is a .NET 8.0 MVC project that provides a platform for managing and purchasing movie tickets. It includes features such as account management, movie listings, and order processing.

Azure: https://eticketsmovies.azurewebsites.net/

### Project Structure
The solution is divided into two main projects:
1.	eTickets: This is the main web application project. It contains the MVC architecture files (Models, Views, Controllers), and the necessary configuration files for the web application.
2.	Library: This is a class library project that contains service classes and interfaces used by the eTickets project. It helps in maintaining a clean separation of concerns and promotes code reusability.
### Key Dependencies
The eTickets project uses several NuGet packages for various functionalities:

•	Microsoft.AspNetCore.Identity.EntityFrameworkCore: Used for user identity management.

•	Microsoft.EntityFrameworkCore: Used as the Object-Relational Mapper (ORM) for data access.

•	Microsoft.EntityFrameworkCore.SqlServer: Used for SQL Server database provider.

•	Microsoft.EntityFrameworkCore.Tools: Used for Entity Framework Core Tools.

The Library project also uses some packages:

•	Microsoft.AspNetCore.Http.Abstractions: Provides HTTP-related interfaces and types.

•	Microsoft.AspNetCore.Identity.EntityFrameworkCore: Used for user identity management.

•	Microsoft.AspNetCore.Mvc.ViewFeatures: Provides MVC view features.

### Services
The Library project contains several service classes that encapsulate business logic related to different entities such as Movies, Orders, Actors, Producers, and Cinemas. These services are used by the controllers in the eTickets project to interact with the data.
### Controllers
The eTickets project contains several controllers that handle HTTP requests and responses. These include AccountController, MoviesController, ProducersController, and ActorsController.
### How to Run
To run the project, you need to have .NET 8.0 SDK installed on your machine. Open the solution in Visual Studio, set eTickets as the startup project and press F5 to run the project.
### Note
Please ensure that the correct connection string is provided in the appsettings.json file for the database connection.
