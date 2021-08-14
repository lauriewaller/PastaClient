# Pasta Client Application

#### An application that queries an API to return pasta data for users. 

#### By **Laurie Waller**

## Technologies Used

* C#
* ASP.NET Core MVC
* ASP.NET Razor
* Entity Framework Core
* .NET 5.0
* MySQL 
* MySQL Workbench
* CSS
* HTML5

## Description

This application provides a UI for an API providing pasta data and is a practice application written for Epicodus coding school homework exercises. To view the API for this application, see the [PastaApi.Solution repo](https://github.com/lauriewaller/PastaApi.Solution).

## Prerequisites
* [.Net Framework](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-2.2.106-macos-x64-installer)
* [MySQL](https://dev.mysql.com/downloads/file/?id=484914)
* [MySQL WorkBench](https://dev.mysql.com/downloads/file/?id=484391)
* dotnet script 
  `dotnet tool install -g dotnet-script`
* Entity Framework Core
  `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`
  `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`
* RestSharp (Read the ["Getting Started"](https://github.com/restsharp/RestSharp/tree/dev/docs/getting-started) page of the RestSharp documentation to get the basic idea of how it works).
  `dotnet add package RestSharp --version 106.6.10`
* Newtonsoft.Json NuGet package (a JSON framework for .NET that can be used for both serialization and deserialization)
  `dotnet add package Newtonsoft.Json --version 12.0.2`

## Setup/Installation Requirements

  1. Go to the main page of the repository (https://github.com/lauriewaller/PastaClient.Solution).
  2. In the top righthand corner of the list of files, click the Code dropdown menu.
  3. Click on the clipboard icon to copy the URL to the GitHub repo.
  4. On your computer, open Terminal and navigate to the folder where you plan to clone the repo folder.
  5. Type in `git clone` and then paste the URL you copied: `git clone https://github.com/lauriewaller/PastaClient.Solution`. Press Enter.
  6. To open your files in [Visual Studio Code](https://code.visualstudio.com/),
  navigate to PastaClient.Solution in Terminal, type `code .`, and press Enter. This will open the application files in VS Code.
  7. In the PastaClient directory, create the file `appsettings.json`. Add the following code and save the file:

    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=laurie_waller;uid={INSERT_USERNAME};pwd={INSERT_PASSWORD};"
      }
    }
  8. Still in the PastaClient directory, type in `dotnet restore` and `dotnet build` to restore dependencies and compile code.
  9. To update the existing migration in your database, run the following commands in the PastaClient directory:
  
  * `dotnet tool install --global dotnet-ef`
  * `dotnet ef database update` (applies the migration for you in Workbench)
 
  10. In the PastaClient directory, type in `dotnet run` to run the program. 


## Known Bugs

* No known errors

## License

MIT

Copyright (c) 2021 by Laurie Waller

## Contact Information

_Laurie Waller (lauriewaller7@gmail.com)_
