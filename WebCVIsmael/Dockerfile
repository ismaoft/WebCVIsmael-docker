# Etapa 1: Build del proyecto
FROM mcr.microsoft.com/dotnet/sdk:9.0-preview AS build
WORKDIR /app

COPY . .
WORKDIR /app/WebCVIsmael
RUN dotnet restore
RUN dotnet publish WebCVIsmael.csproj -c Release -o /app/publish

# Etapa 2: Imagen final
FROM mcr.microsoft.com/dotnet/aspnet:9.0-preview AS runtime
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 80
ENTRYPOINT ["dotnet", "WebCVIsmael.dll"]
