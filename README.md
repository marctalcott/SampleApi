# SampleApi
A quick sample .Net core Api with layered architecture.

This was created 9/26/2019, and I have no intention of keeping this up to date. This is just here to share with a co-worker as a starting point for a project. 

If you want to run it, open it in Visual Studio, and set the SampleAPI project as the start up project.
Run the database script in the Readme project to create your database.
Set your connection string your SampleApi/AppSettings.json file

This uses dependency injection to inject your objects into classes as needed.
AutoMapper is used to map EF objects to DTO objects (you don't want to pass EF object to your API!).

If you update your database, you'll need to update your Data project. To do that, open a command window in your Data project and run this command: (fix your password as needed)

 *****  Important!!! ******************** 
 When you run this command it adds this connection string into your Data/SampleDbContext file. REMOVE IT IMMEDIATELY and don't ever commit your code with that in your file. You don't need it there because your connection string is setup in your API project, but this is just what the scaffold command does. I don't know of an option to prevent it. but there may be one by now.
 ***************************************
 
dotnet ef dbcontext scaffold "server=localhost;database=SampleDb;user=sa;password=Yourpassword;” "Microsoft.EntityFrameworkCore.SqlServer" -v -f --schema dbo


Also read up on proper REST endpoint creation: https://pages.apigee.com/rs/apigee/images/api-design-ebook-2012-03.pdf


Cheers,
Marc
