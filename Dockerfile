FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["EfCoreOwnedType.Data/EfCoreOwnedType.Data.csproj", "EfCoreOwnedType.Data/"]
COPY ["EfCoreOwnedType.Entities/EfCoreOwnedType.Entities.csproj", "EfCoreOwnedType.Entities/"]
COPY ["EfCoreOwnedType.WebApi/EfCoreOwnedType.WebApi.csproj", "EfCoreOwnedType.WebApi/"]
RUN dotnet restore "EfCoreOwnedType.WebApi/EfCoreOwnedType.WebApi.csproj"
COPY . .
WORKDIR "/src/EfCoreOwnedType.WebApi"
RUN dotnet build "EfCoreOwnedType.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EfCoreOwnedType.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
ENV ASPNETCORE_URLS=http://0.0.0.0:5000
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EfCoreOwnedType.WebApi.dll"]
