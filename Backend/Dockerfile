# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
#EXPOSE 8081


# This stage is used to build the service project
#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
#ARG BUILD_CONFIGURATION=Release
#WORKDIR /src
#COPY ["Backend/Backend.csproj", "Backend/"]
#RUN dotnet restore "./Backend/Backend.csproj"
#COPY . .
#WORKDIR "/src/Backend"
#RUN dotnet build "./Backend.csproj" -c $BUILD_CONFIGURATION -o /app/build


# Adjusted Dockerfile for backend



FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Backend.csproj", "./"]
RUN dotnet restore "./Backend.csproj"
COPY . .
RUN dotnet build -c Release -o /app/build
RUN dotnet publish -c Release -o /app/publish
ENTRYPOINT ["dotnet", "/app/publish/Backend.dll"]



# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Backend.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Backend.dll"]



# Stage 1: Build the React app
#FROM node:18 AS frontend-build
#WORKDIR /app
#COPY ./frontend/package*.json ./
#RUN npm install
#COPY ./frontend .
#RUN npm run build

# Stage 2: Build the .NET app
#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
#WORKDIR /src
#COPY ["Backend/Backend.csproj", "Backend/"]
#RUN dotnet restore "./Backend/Backend.csproj"
#COPY . .
#WORKDIR "/src/Backend"
#RUN dotnet build "./Backend.csproj" -c Release -o /app/build
#
## Stage 3: Publish the .NET app
#FROM build AS publish
#RUN dotnet publish "./Backend.csproj" -c Release -o /app/publish /p:UseAppHost=false
#
## Stage 4: Final runtime image
#FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
## Copy React build files to wwwroot
##COPY --from=frontend-build /app/dist ./wwwroot
#EXPOSE 8080
#ENTRYPOINT ["dotnet", "Backend.dll"]
#