FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["softplayer/softplayer.csproj", "softplayer/"]
RUN dotnet restore "softplayer/softplayer.csproj"
COPY . .
WORKDIR "/src/softplayer"
RUN dotnet build "softplayer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "softplayer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "softplayer.dll"]