# Learn about building .NET container images:
# https://github.com/dotnet/dotnet-docker/blob/main/samples/README.md

FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
ARG TARGETARCH
WORKDIR /src

# copy csproj files
COPY ICM.WebSites.Application/*.csproj ICM.WebSites.Application/
COPY ICM.WebSites.Cms/*.csproj ICM.WebSites.Cms/
COPY ICM.WebSites.Domain/*.csproj ICM.WebSites.Domain/
COPY ICM.WebSites.Infrastructure/*.csproj ICM.WebSites.Infrastructure/

# restore as distinct layers
RUN dotnet restore ICM.WebSites.Cms/ICM.WebSites.Cms.csproj -a $TARGETARCH

# alpine
RUN apk add --update nodejs npm
RUN npm install -g pnpm


# copy and publish app and libraries
COPY ICM.WebSites.Application/ ICM.WebSites.Application/
COPY ICM.WebSites.Cms/ ICM.WebSites.Cms/
COPY ICM.WebSites.Domain/ ICM.WebSites.Domain/
COPY ICM.WebSites.Infrastructure/ ICM.WebSites.Infrastructure/
RUN dotnet publish ICM.WebSites.Cms/ICM.WebSites.Cms.csproj -a $TARGETARCH --no-restore --configuration Release -o /app

# Enable globalization and time zones:
# https://github.com/dotnet/dotnet-docker/blob/main/samples/enable-globalization.md
# final stage/image

FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine

ENV \
    DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false \
    LC_ALL=en_US.UTF-8 \
    LANG=en_US.UTF-8
RUN apk add --no-cache \
    icu-data-full \
    icu-libs

WORKDIR /app
COPY --from=build /app .

RUN sed -i 's/\[openssl_init\]/# [openssl_init]/' /etc/ssl/openssl.cnf
RUN printf "\n\n[openssl_init]\nssl_conf = ssl_sect" >> /etc/ssl/openssl.cnf
RUN printf "\n\n[ssl_sect]\nsystem_default = ssl_default_sect" >> /etc/ssl/openssl.cnf
RUN printf "\n\n[ssl_default_sect]\nMinProtocol = TLSv1\nCipherString = DEFAULT@SECLEVEL=0\n" >> /etc/ssl/openssl.cnf


ENTRYPOINT ["./ICM.WebSites.Cms"]
