FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR "/src"
COPY ["./ApolloIntegration.WorkerApp/*.csproj", "./ApolloIntegration.WorkerApp/"]
COPY ["./ApolloIntegration.Application/*.csproj", "./ApolloIntegration.Application/"]
COPY ["./ApolloIntegration.Domain/*.csproj", "./ApolloIntegration.Domain/"]
COPY ["./ApolloIntegration.Infrastructure/*.csproj", "./ApolloIntegration.Infrastructure/"]
WORKDIR "/src/ApolloIntegration.WorkerApp"
RUN dotnet restore "ApolloIntegration.WorkerApp.csproj"
WORKDIR "/src"
COPY ./ .
WORKDIR "/src/ApolloIntegration.WorkerApp"
RUN dotnet build "ApolloIntegration.WorkerApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ApolloIntegration.WorkerApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApolloIntegration.WorkerApp.dll"]