# Base Image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Metadata
LABEL \
    org.opencontainers.image.title="Minimal API" \
    org.opencontainers.image.description="Minimal API" \
    org.opencontainers.image.authors="@dockerutility"

# Create directory inside the container image to store application code
RUN mkdir -p /app

# Copy the directory specified from the Build command (.) to the application code directory
COPY . /app

# Set the working directory
WORKDIR /app

# Install dependencies
RUN dotnet restore

# Build project & Publish the code to the output folder
RUN dotnet publish -c Release -o output

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
COPY --from=build /app/output .

# Execute the application within the container
ENTRYPOINT ["dotnet", "MinimalApi.dll"]