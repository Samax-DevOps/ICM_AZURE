FROM mcr.microsoft.com/dotnet/aspnet:8.0-preview-alpine AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0-preview-alpine AS build
WORKDIR /src
COPY ["ICM.WebSite/ICM.WebSite.csproj", "ICM.WebSite/"]
RUN dotnet restore "ICM.WebSite/ICM.WebSite.csproj"
COPY . .
WORKDIR "/src/ICM.WebSite"
RUN dotnet build "ICM.WebSite.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ICM.WebSite.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ICM.WebSite.dll"]
