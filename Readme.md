# Visual Studio Code extensions and good practices for .NET developers

## Extensions 
### 1.	C# by Microsoft (This has benefit when you open a .net project folder, it asks for permission to install the missed assets, click allow and then .vscode folder is created together with two files: launch.json and tasks.json. Install 'C# Dev Kit' will also installed 'C#' and .'NET Install Tool'. But you won’t see the prompt to install the missed assets!)
### 2.	.NET Core Test Explorer by Jun Han
### 3.	NuGet Package Manager by jmrog

## Commands to create, build and run a project
* dotnet new console -n MyProject
* dotnet build
* dotnet run

## Unit tests
* create a new folder, and then move files into it, except Readme.md and .gitignore
* Run the command to create the unit text projext:
* dotnet new xunit -n tests
* Create a solution
* - dotnet new sln
* Add the projects into the solution
* - dotnet sln add ./src/MyProject.csproj
* - dotnet sln add ./tests/tests.csproj
* close the folder and reopen it in vs code
* - C# (Extension) prompts "Required assets to build and debug are missing from 'MyProject'". Click Yes.
* - In the Command Palette, select 'MyProject'
* Press F5 key to verify it all works

* Can run tests by
* - dotnet test
* - Open test source file, run a test
* - From the .NET Core Test Explorer extension 

## More Visual Studio Code extensions that are enhancing .NET development workflow
*	GitLens by GitKraken
*	C# Dev Kit by Microsoft
*	C# Extensions by JosKreative
*	Auto-Using for C# by Fudge
*	C# Namespace Autocompletion by Adrian Wilczynski
*	Database Client by Weijan Chen – MySQL, PostgresSQL, SQLite, Redis and lastic Search
*	GitHub Copilot by GitHub 

## Best practices for .NET development in Visual Studio Code
### Code organization in project structure
* Divide code into logical modules
* Follow consistent naming conventions
* Use different projects for different functionalities
* Implement namespaces for related classes
* Remove unused files

### Documentation Best Practices
* Provide meaningful comments
* Use XML comments for public APIs
* Choose clear, concise names
* Use a document generator
* Update comments as code evolves

### Version Control Collaboration
* Initialize a Git repository when you start a new project
* Commit changes regularly with descriptive messages
* Use branches for separate features or fixes
* Collaborate using a centralized Git repository
* Review and resolve conflicts during merges

Testing and continuous integration (is vital for maintaining code quality)
### Testing Best Practices
* Write unit tests for code verification
* Automate testing with continuous integration tools
* Run tests on every commit to maintain stability
* Monitor test results and address failures promptly