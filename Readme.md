# Extensions 
### 1.	C# by Microsoft (This has benefit when you open a .net project folder, it asks for permission to install the missed assets, click allow and then .vscode folder is created together with two files: launch.json and tasks.json. Install 'C# Dev Kit' will also installed 'C#' and .'NET Install Tool'. But you won’t see the prompt to install the missed assets!)
### 2.	.NET Core Test Explorer by Jun Han
### 3.	NuGet Package Manager by jmrog

# Unit tests
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