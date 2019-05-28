FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["ravi.learn.web.docker/ravi.learn.web.docker.csproj", "ravi.learn.web.docker/"]
RUN dotnet restore "ravi.learn.web.docker/ravi.learn.web.docker.csproj"
COPY . .
WORKDIR "/src/ravi.learn.web.docker"
RUN dotnet build "ravi.learn.web.docker.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ravi.learn.web.docker.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ravi.learn.web.docker.dll"]