@echo off
setlocal

REM Run the TravelBlog.API project (Development)
set ASPNETCORE_ENVIRONMENT=Development
dotnet run --project "TravelBlog.API\TravelBlog.API.csproj"
