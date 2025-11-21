# --- Стадия сборки (build) ---
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Копируем файлы проекта и восстанавливаем зависимости
COPY *.csproj .
RUN dotnet restore

# Копируем все остальные исходные файлы и публикуем приложение
COPY . .
RUN dotnet publish -c Release -o /app/publish

# --- Стадия выполнения (runtime) ---
FROM mcr.microsoft.com/dotnet/aspnet:9.0-alpine AS runtime
WORKDIR /app

# Копируем только опубликованные файлы из стадии 'build'
COPY --from=build /app/publish .

EXPOSE 8080
ENTRYPOINT ["dotnet", "VistavkaApp.dll"]
