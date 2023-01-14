[![Open in Gitpod](https://gitpod.io/button/open-in-gitpod.svg)](https://gitpod.io/#https://github.com/ooti2022/blue)

In GitPod, load all the dependencies, then try this:

1. Open the Terminal
2. Type `cd Kiosk.App` to enter the main program directory
3. Type `dotnet run` to run the main program - you should see "Dotnet works!"
4. Type `dotnet run -- read` to run the example "read" command
5. Type `dotnet test ..` to run the tests - you should see one passed test
6. Edit `Kiosk.Test/ReadTest.cs` to make the test fail

This example app does not do anything useful, except show you C# CLI programming basics.
It contains some example code that shows how you can:
- use subcommands: a bit like how Git has "git add" and "git push", this lets you do "dotnet run -- read" and "dotnet run -- whateveryouwanthere --bla --foo etc"
- run tests with C#.

You're expected to change pretty much everything, or even throw everything away. Your call! 
