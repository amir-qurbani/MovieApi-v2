FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

WORKDIR /build
COPY . .
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:9.0

WORKDIR /app
COPY --from=build /build/out .

ENTRYPOINT [ "dotnet", "MovieApi-v2.dll" ]