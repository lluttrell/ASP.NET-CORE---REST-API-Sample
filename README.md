# ASP.NET CORE / REST API Sample

This repository is created for teaching and demonstration purposes. It is meant to help students learn how to work with REST APIs and apply different layers (data layer, business logic layer, and data access layer). The project is incomplete and suffers of several limitations:

1) No continuous integration.
2) No unit testing.
3) Missing end-points / methods.
4) No authentication / authorization.
5) Missing API documentation.
6) No API versioning.
7) Semi-modular.
8) Uses .NET CORE 2.2 which is deprecated. Should migrate to .NET CORE 3.X.

For further information about REST API standards, check this site: [https://restfulapi.net/](https://restfulapi.net/).

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. 

``
Note that the recommended IDE for this project is Visual Studio.
``
    
### Prerequisites

The things you need to install before you proceed with development.

1) [Visual Studio (2017+)](https://visualstudio.microsoft.com/downloads/) [recommended]: make sure to include the ASP.NET and web development package.
2) [.NET Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2): install the SDK (required) and the Runtime & Hosting Bundle (optional: if you need to test using IIS instead of IIS Express).
3) IIS Express [recommended]: usually it is included with the installation of Visual Studio.
4) [MySQL Community](https://dev.mysql.com/downloads/installer/) [required].

### Installing

A step by step guide to get you started with development.

#### Download and clone the repository

```
git clone https://github.com/omaddam/ASP.NET-CORE---REST-API-Sample.git
```

#### Initialize git flow

```
git flow init
```

#### Restore NuGet packages

Using one of the following:

- Command line:

    ```
    nuget restore "REST API.sln"
    ```

- Package Manager Console in Visual Studio:

    ```
    Update-Package
    ```

- Visual Studio rebuild: it automatically restores the packages on rebuild.

#### Build the projects

Using one of the following:

- Command line:

    ```
    dotnet build
    ```
    For more information, see [dotnet build command](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-build).

- Visual Studio shortcut:

    ```
    CTRL + SHIFT + B
    ```

#### Setup the database

1) Create a new database/schema in MySQL.
2) Create a new table `students` which has 3 columns:
   1) `id` varchar(45) / primary key
   2) `first_name` varchar(45)
   3) `last_name` varchar(45)

#### Setup the appsettings.json

1) Update the database connection string.
   1) For more information on how to construct a connection string, click [here](https://www.connectionstrings.com/mysql/).
        
#### Run the webservice

Use either the command line or Visual Studio.

##### Using command line

1) Set the environment variables:

    1) Set development mode to display unhandled exceptions in the browser.

        ```
        SET ASPNETCORE_ENVIRONMENT=Development
        ```

2) Run:

    1) Using the source project:
    
        ```
        dotnet run Webservice.csproject
        ```

    2) Using the build: (often found in bin\Debug or bin\Release)
    
        ```
        dotnet Webservice.dll
        ```

##### Using Visual Studio

1) Set the **Webservice** project as the startup project. 
    
    
2) Set the launch profile:
    1) Open the properties of Webservice project.
    2) Go to Debug section.
    3) Select "**IIS Express**" or "**Console**" profile.
    
    The list of all available launch profiles can be found in Webservice\Properties\launchSettings.json.

3) Set the webservice project as the startup project.
    
4) Run the project:
    ``
    F5
    ``