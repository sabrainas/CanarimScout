FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY CanarinScout.WebApi/*.csproj ./CanarinScout.WebApi/
RUN dotnet restore ./CanarinScout.WebApi/CanarinScout.WebApi.csproj

COPY . .
WORKDIR /src/CanarinScout.WebApi
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "CanarinScout.WebApi.dll"]