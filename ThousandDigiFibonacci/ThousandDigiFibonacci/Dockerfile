FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ThousandDigiFibonacci/ThousandDigiFibonacci.csproj", "ThousandDigiFibonacci/"]
RUN dotnet restore "ThousandDigiFibonacci/ThousandDigiFibonacci.csproj"
COPY . .
WORKDIR "/src/ThousandDigiFibonacci"
RUN dotnet build "ThousandDigiFibonacci.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ThousandDigiFibonacci.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ThousandDigiFibonacci.dll"]
