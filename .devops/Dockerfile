FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
RUN mkdir argonaut-subscription-server-proxy
COPY solutions ./solutions
COPY argonaut-subscription-server-proxy/*.csproj ./argonaut-subscription-server-proxy
RUN dotnet restore solutions/argonaut-subscription-server-proxy.sln

# Copy everything else and build
COPY . ./
RUN dotnet publish argonaut-subscription-server-proxy/argonaut-subscription-server-proxy.csproj -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
COPY --from=build-env /app/argonaut-subscription-server-proxy/out .
ENTRYPOINT ["dotnet", "argonaut-subscription-server-proxy.dll"]
