#Project Name
    Pokémon World by Brian Lane

##Project Description
    As a huge fan of the Pokémon Franchise I wanted to try my hand at creating a 
    basic text based adventure game based on Pokémon. 
    The goal of this project was to utilize the various concepts I had learned in a three month
    Software Development bootcamp at Eleven Fifty Academy. The project utilizes an Azure SQL Server Database and the 
    Hosted Blazor WebAssembly with Authentication framework. In the app you are able to create Pokémon based of the ones already
    created in the Pokémon franchise or you can create an entirely new Pokémon. You can also create an manage the various items one 
    might use in a Pokémon game such as Poké Balls, Health Items, TMs, Revive Items, and Status Removal Items. 
    I have begun work on additional features such as expanding on the game element and will update this as new work is completed. 
    This project was created using .Net 7 framework.

##Installation 
    To install the project simply clone the repository from GitHub. 
    In order to install the project, navigate to the directory that you want the project stored in via CLI.
    Once in the Directory for the project type the following in your Terminal or Powershell:
        git clone https://github.com/brianlane01/PokeRaterCatcherApp.git
    
    This will clone the project to your local machine. 

        The project also uses the MudBlazor nuget package which has already been added to the project so you should not have issues there.

    You will also need to set up your on Databae and Database Connection as this version of the project utilizes my local DB. 
        1. First run the following command in the terminal:
            dotnet user-secrets init --project Server
        2. Then run the following command:
            dotnet user-secrets set "ConnectionString:DefaultConnection" "YourConnectionString" --project Server 
                //DefaultConnection can be whatever youn want to name the connection.
                // If you go with DefaultConnection ensure you update the Program.cs in the Server project 
                // as it is currently set to "PokemonDB"
    If you plan to update the database through migrations ensure that you run the following commands in the terminal.
        1. dotnet new tool-manifest
        2. dotnet tool install dotnet-ef
    As the packages are already in this project you should not need to do the following but if needed:
        3. dotnet add package Microsoft.EntityFrameworkCore.Desin --version 7.0.13

    Once you are ready to update or create the database you can run the following command in the terminal:
        dotnet ef migrations add NameofTheMigrationToProvideContext -p Server
        dotnet ef database update -p Server

    You will need to ensure that you have the dotnet wasm tools in order to get this simply:
        Execute "dotnet workload install wasm-tools" in an administrative command shell or terminal window.
    If you plan to update the database through migrations ensure that you

 ##Usage 
    To use the project ensure that you have a Docker container running that has a Sql Server Database connection
    Once that is up and running and you have performed an initail migration you con run the following command in the terminal

    If in the main directory of the project:
        dotnet watch run --project Server

    This will bring up a webpage in your default browser.
    As long as you have installed everything correctly and set up the Database and connections properly
    you will be able touse the app. From here you can either expand the Nav bar at the top of the page to go to various aspects of the app
    or at the bottom of the homepage you can select to start the game and play what I have built out currently.

##Contributing 
    I welcome any feedback on the project and welcome suggestion on how to make it better. This is my first attempt at a full stack app and my first time using Blazor WebAssembly. 
    if you do make changes please:
        Fork the repository
        Create a new branch
        Make your changes
        Submit a pull request

##Database wireframe 
    Below is a link to the wireframe for the database that is being update as changes are made to the database structure.
        https://dbdiagram.io/d/PokeRater%2FCatcher-654cefa77d8bbd6465db5e42

##Acknowledgements
    Specail thanks to Martin Flaherty at Eleven Fifty Academy for helping me with various issues I encounterd
    throughout the course of the project. 
    Also as the project used information from and has a connection setup to PokeApi special thanks them for their work in maintianing the API.




