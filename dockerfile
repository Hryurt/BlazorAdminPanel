FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY RoyalstarAdminPanel.csproj .
RUN dotnet restore "RoyalstarAdminPanel.csproj"
COPY . .
RUN dotnet build "RoyalstarAdminPanel.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RoyalstarAdminPanel.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RoyalstarAdminPanel.dll"]