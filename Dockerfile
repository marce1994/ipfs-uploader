FROM microsoft/dotnet:sdk AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./ ./
WORKDIR /app/Uploader.Web

# Build
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app/Uploader.Web/out .
ENTRYPOINT ["dotnet", "Uploader.Web.dll"]