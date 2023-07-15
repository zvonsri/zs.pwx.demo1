# zs.pwx.demo1

```txt
  dotnet new sln
  dotnet new console -o zscon
  dotnet sln add zscon/zscon.csproj
  dotnet build
  dotnet new classlib -o zslib
  dotnet sln add zslib/zslib.csproj
  dotnet new xunit -o zsxunit
  dotnet sln add zsxunit/zsxunit.csproj
  dotnet add zscon\zscon.csproj reference zslib\zslib.csproj
  dotnet add zsxunit\zsxunit.csproj reference zslib\zslib.csproj
  dotnet run --project zscon/zscon.csproj
  dotnet test
```
