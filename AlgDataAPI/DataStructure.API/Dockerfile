#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DataStructure.API/DataStructure.API.csproj", "DataStructure.API/"]
RUN dotnet restore "DataStructure.API/DataStructure.API.csproj"
COPY . .
WORKDIR "/src/DataStructure.API"
RUN dotnet build "DataStructure.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DataStructure.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DataStructure.API.dll"]
