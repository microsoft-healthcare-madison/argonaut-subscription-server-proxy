FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env
WORKDIR /app

# Copy everything else and build
COPY . ./
RUN dotnet publish argonaut-subscription-server-proxy/argonaut-subscription-server-proxy.csproj -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
COPY --from=build-env /app/argonaut-subscription-server-proxy/out .
ENTRYPOINT ["dotnet", "argonaut-subscription-server-proxy.dll"]
