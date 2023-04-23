# Park Lookup Api

#### By Dani Steely

#### _An API that will list state and national parks and the associated data_

## Technologies Used
* _C#_
* _ASP.NET Core MVC_
* _Entity Framework Core_
* _MySQL_
* _Swagger UI_

## Description
This application is a self-contained project developed as part of [Epicodus][Epicodus] coursework in [C# with .Net][C# course main]. It was completed following the ["Building an API"][C# chapter] module in the curriculum. This project demonstrates proficiency in creating an ASP.NET Core Web API with full CRUD functionality, using RESTFUL principles. It uses Swagger UI for documenting API endpoints.

## Setup/Installation Requirements
#### Setting up directories
* clone this repo to your desktop
* navigate to project directory in your terminal
* follow the next steps for creating an appsettings file and setting up a database

#### Creating appsettings files
* navigate to "ParksApi" directory
* 

#### Database setup
* this project uses ["Code-First Development with Migrations"][Code-First Dev]
* navigate to the ParksApi directory and use the command:

```
$ dotnet ef database update
```

* use the following command to then build the database and get the app running:

```
$ dotnet run
```
or:
```
$ dotnet watch run
```

## Known Bugs
* No known bugs

## License

_MIT License_

Copyright (c) _4/22/23_ _Dani Steely_

[Epicodus]: https://www.epicodus.com/
[C# course main]: https://www.learnhowtoprogram.com/c-and-net-part-time
[C# chapter]: https://www.learnhowtoprogram.com/c-and-net-part-time/building-an-api
[Code-First Dev]: https://www.learnhowtoprogram.com/c-and-net-part-time/many-to-many-relationships/code-first-development-and-migrations


