# Etapa 1: Build del proyecto
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

COPY WebCVIsmael/*.csproj ./WebCVIsmael/
RUN dotnet restore ./WebCVIsmael/WebCVIsmael.csproj

COPY . .
WORKDIR /app/WebCVIsmael
RUN dotnet publish -c Release -o /app/publish

# Etapa 2: Imagen final de runtime
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 80
ENTRYPOINT ["dotnet", "WebCVIsmael.dll"]
