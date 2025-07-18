# Etapa 1: Build del proyecto
FROM mcr.microsoft.com/dotnet/sdk:9.0-preview AS build
WORKDIR /app

# Copia todo el contenido
COPY . .

# Establece el directorio de trabajo dentro del proyecto
WORKDIR /app/WebCVIsmael

# Restaurar dependencias del proyecto principal
RUN dotnet restore WebCVIsmael.csproj

# Publicar (compilar para producción)
RUN dotnet publish WebCVIsmael.csproj -c Release -o /app/publish

# Etapa 2: Imagen final de runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0-preview AS runtime
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 80
ENTRYPOINT ["dotnet", "WebCVIsmael.dll"]
