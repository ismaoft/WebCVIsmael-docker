# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:9.0-preview AS build
WORKDIR /app
COPY . .

# Restaurar dependencias desde la solución
RUN dotnet restore WebCVIsmael.sln

# Publicar el proyecto
RUN dotnet publish WebCVIsmael.csproj -c Release -o /app/publish

# Etapa de runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0-preview AS runtime
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 80
ENTRYPOINT ["dotnet", "WebCVIsmael.dll"]
