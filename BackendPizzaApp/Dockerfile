FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

WORKDIR /home/app

COPY . /home/app

ENTRYPOINT ["dotnet", "./bin/Debug/netcoreapp3.1/BackendPizzaApp.dll"]