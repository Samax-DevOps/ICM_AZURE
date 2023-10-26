FROM mcr.microsoft.com/dotnet/aspnet:8.0-preview-alpine AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0-preview-alpine AS build
WORKDIR /src
COPY ["ICM.WebSites.Cms/ICM.WebSites.Cms.csproj", "ICM.WebSites.Cms/"]
RUN dotnet restore "ICM.WebSites.Cms/ICM.WebSites.Cms.csproj"
COPY . .
WORKDIR "/src/ICM.WebSites.Cms"
RUN dotnet build "ICM.WebSites.Cms.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ICM.WebSites.Cms.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ICM.WebSites.Cms.dll"]
