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
* create an appsettings.json that contains the following code:
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE-NAME];uid=[USERNAME];pwd=[PASSWORD]"
  }
}
```
* within the appsettings.json file, you will need to replace `[DATABASE-NAME]` with the name of the database, `[USERNAME]` with your username, and `[PASSWORD]` with your password
* The "Logging" key in the file configures logging. The "AllowedHosts" key configures the host names that can access the API.
* create an appsettings.Development.json file that contains the following code:
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Trace",
      "Microsoft.AspNetCore": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}
```

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

## API Endpoints
_Parks_
```
GET http://localhost:5001/api/parks
GET http://localhost:5001/api/parks/{id}
POST http://localhost:5001/api/parks/
PUT http://localhost:5001/api/parks/{id}
DELETE http://localhost:5001/api/parks/{id}
```
* "{id}" in the listed endpoints will be replaced with the specific id of the park required by the request

* A POST request requires a body to create a park. Use the following code as an example body for a POST request:
```json
{
    "parkId": 4,
    "parkName": "Yosemite National Park",
    "parkCode": "YOSE",
    "designation": "National Park",
    "locationState": "California",
    "governingBody": "NPS",
    "url": "https://www.nps.gov/yose/index.htm",
    "areaInAcres": 759620
  }
```
* A PUT request requires the same content in its request body, but you MUST ensure that the id of the park you wish to update matches the "parkId" in the request body

### Swagger UI Documentation
This project uses Swagger UI during development to document endpoints. You can view the Swagger UI by running the application with
```
$ dotnet watch run
```
This will redirect to https://localhost:5001/swagger/index.html, and the UI at this URL lists the endpoints and the Park schema. The UI also provides an interface that can be used to test the API endpoints and view response codes. Before using the UI to test out the endpoints, please read the notes about request bodies in the previous section of this README.

## Known Bugs
* No known bugs

## License

_MIT License_

Copyright (c) _4/22/23_ _Dani Steely_

[Epicodus]: https://www.epicodus.com/
[C# course main]: https://www.learnhowtoprogram.com/c-and-net-part-time
[C# chapter]: https://www.learnhowtoprogram.com/c-and-net-part-time/building-an-api
[Code-First Dev]: https://www.learnhowtoprogram.com/c-and-net-part-time/many-to-many-relationships/code-first-development-and-migrations


