# SampleApi
A quick sample .Net core Api with layered architecture.

This was created 9/26/2019, and I have no intention of keeping this up to date. This is just here to share with a co-worker as a starting point for a project. 

If you want to run it, open it in Visual Studio, and set the SampleAPI project as the start up project.
Run the database script in the Readme project to create your database.
Set your connection string your SampleApi/AppSettings.json file

This uses dependency injection to inject your objects into classes as needed.
AutoMapper is used to map EF objects to DTO objects (you don't want to pass EF object to your API!).

Cheers,
Marc
