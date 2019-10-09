FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["InfoClients.Api/InfoClients.Api.csproj", "InfoClients.Api/"]
RUN dotnet restore "InfoClients.Api/InfoClients.Api.csproj"
COPY . .
WORKDIR "/src/InfoClients.Api"
RUN dotnet build "InfoClients.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "InfoClients.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "InfoClients.Api.dll"]