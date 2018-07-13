ARG runtime_base_tag=2.1-runtime-alpine
ARG build_base_tag=2.1-sdk-alpine

FROM microsoft/dotnet:${build_base_tag} AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY opcpublisher/*.csproj ./opcpublisher/
WORKDIR /app/opcpublisher
RUN dotnet restore

# copy and publish app
WORKDIR /app
COPY opcpublisher/. ./opcpublisher/
WORKDIR /app/opcpublisher
RUN dotnet publish -c Release -o out

# start it up
FROM microsoft/dotnet:${runtime_base_tag} AS runtime
# Add an unprivileged user account for running the module
RUN adduser -s /bin/sh -D moduleuser
WORKDIR /app
COPY --from=build /app/opcpublisher/out ./
WORKDIR /appdata
RUN chown -R moduleuser /appdata
USER moduleuser
ENTRYPOINT ["dotnet", "/app/opcpublisher.dll"]