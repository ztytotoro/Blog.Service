#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Blog.Service/Blog.Service.csproj", "Blog.Service/"]
COPY ["ApiDocument/ApiDocument.csproj", "ApiDocument/"]
COPY ["DataTransfer/DataTransfer.csproj", "DataTransfer/"]
COPY ["Common/Common.csproj", "Common/"]
COPY ["DataManager/DataManager.csproj", "DataManager/"]
COPY ["Database/Database.csproj", "Database/"]
RUN dotnet restore "Blog.Service/Blog.Service.csproj"
COPY . .
WORKDIR "/src/Blog.Service"
RUN dotnet build "Blog.Service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Blog.Service.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Blog.Service.dll"]