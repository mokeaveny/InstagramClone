#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["InstagramClone.Api/InstagramClone.Api.csproj", "InstagramClone.Api/"]
RUN dotnet restore "InstagramClone.Api/InstagramClone.Api.csproj"
COPY . .
WORKDIR "/src/InstagramClone.Api"
RUN dotnet build "InstagramClone.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "InstagramClone.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InstagramClone.Api.dll"]