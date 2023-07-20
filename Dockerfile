#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["SportsShop.WebApi.csproj", "./"]
RUN dotnet restore "./SportsShop.WebApi.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "SportsShop.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SportsShop.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SportsShop.WebApi.dll"]