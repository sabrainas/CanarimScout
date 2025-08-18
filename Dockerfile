FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY CanarinScout.WebApi/*.csproj ./CanarinScout.WebApi/
COPY CanarinScout.Application/*.csproj ./CanarinScout.Application/
COPY CanarinScout.Domain/*.csproj ./CanarinScout.Domain/
COPY CanarinScout.Infrastructure/*.csproj ./CanarinScout.Infrastructure/

RUN dotnet restore ./CanarinScout.WebApi/CanarinScout.WebApi.csproj

COPY . .
WORKDIR /src/CanarinScout.WebApi
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "CanarinScout.WebApi.dll"]