FROM mcr.microsoft.com/dotnet/aspnet:8.0-preview-alpine AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0-preview-alpine AS build
WORKDIR /src

RUN apk add --update nodejs npm
RUN npm install -g pnpm

COPY ["ICM.WebSite.Cms/ICM.WebSite.Cms.csproj", "ICM.WebSite.Cms/"]
RUN dotnet restore "ICM.WebSite.Cms/ICM.WebSite.Cms.csproj"
COPY . .
WORKDIR "/src/ICM.WebSite.Cms"
RUN dotnet build "ICM.WebSite.Cms.csproj" -c Release -o /app/build

#FROM build AS publish
#RUN dotnet publish "ICM.WebSite.Cms.csproj" -c Release -o /app/publish /p:UseAppHost=false

#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ICM.WebSite.Cms.dll"]
