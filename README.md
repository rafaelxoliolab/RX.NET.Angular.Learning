# Learning Angular with .NET programming
Learning Angular with .NET

By Rafael Xolio

## Resources
- [MDN: JavaScript Classes](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Classes)


## Create projects

- Open Gitbash

``` cmd
$dotnet --info
$dotnet -h
$dotnet new list
$dotnet new sln
$dotnet new webapi -o [APIName] -controllers
$dotnet new classlib -o [LibName]

$dotnet sln add [projectName]

$dotnet add reference ../infrastructure

$dotnet restore
$dotnet run

```

Adding swagger to .net 10+
``` cmd
dotnet add package Swashbuckle.AspNetCore.SwaggerUI

```