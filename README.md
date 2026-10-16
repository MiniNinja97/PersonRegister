# Person Register

## About the Project

**PersonRegister** is a C# console application created as part of a .NET programming assignment. It allows users to view, sort and search for people through an interactive menu.

### Features

- Display all people sorted by ID or name.
- Display the first five people sorted by ID or name.
- Search for people by name.
- Display detailed information about each person.
- Handle invalid menu selections and empty searches.
- Choose between local data and data retrieved from an external API.
- Run register functions directly through terminal commands.

## How to Run

1. Clone the repository.
2. Open a terminal in the project directory.
3. Build the application using `dotnet build`.
4. Run the application using `dotnet run`.
5. Follow the console menu.

## How To Run With Terminal Commands 
1. Clone the repository.
2. Open a terminal in the project directory.
3. Build the application using `dotnet build`.
4. Run the application using `dotnet run -- list`, `dotnet run -- list --top5`, `dotnet run -- list --sort`,
`dotnet run -- list --sort --top5`, `dotnet run -- list --search Adam`

When using terminal commands, the application uses the local data source. Invalid commands display an error message and the application exits.

## Project Structure

I divided the person information into three classes because I found it easier to organize the data this way:

- **Identification** – ID and name.
- **ContactDetails** – Email and address information.
- **Business** – Company name and slogan.

The **Person** class bring all these together. I chose this structure because it makes the information easier to use, understand, sort, and search through.

## C# and .NET

C# is a programming language while .NET is a development platform that provides tools, libraries, and a runtime for applications such as websites, desktop applications and APIs.

I have previously worked with JavaScript and TypeScript and noticed several similarities. Functions and methods have similar structures and `console.log()` in JavaScript works similarly to `Console.WriteLine()` in C#.

One difference is that C# is statically typed, while JavaScript is dynamically typed. TypeScript is more similar to C# because both use types.

## Development Tools

**Visual Studio** is an integrated development environment used to write, build, run, and debug applications. I use VS Code on Linux Mint which allows me to do basically the same things with extensions and the .NET SDK.

I prefer creating projects through terminal commands and opening them in VS Code instead of starting projects through the application's interface.

**PowerShell** is a command-line shell for running commands and managing files. I use the Linux terminal instead, which I personally find easier to work with.

**Git** is a version control system I use to track changes, save versions, and manage branches.

A **commit** saves a version of my work with a descriptive message. A **branch** is a separate line of development, like another page in a notebook, where I can work without mixing different tasks.

For this project, I worked on a branch named `develop`, made commits and later merged it into the `main` branch and pushed the project to my GitHub.

For the VG requirements I created a separate branch named `vgversion`. This allowed me to continue developing the application while keeping the original G version unchanged in the `main` branch.

## Data Sources

The application has two different data sources:

1. # PersonData: Contains 10 hardcoded people.

2. # ApiPersonData: Retrieves 100 people from the RandomUser API.

Both classes implement the IPersonData interface which contains the GetPeople() method.

By using the same interface the register functions can work with both data sources without needing to change their code.

When running the application without terminal arguments the user can choose which data source to use through the interactive menu.

This makes the application easier to maintain and extend with additional data sources in the future.