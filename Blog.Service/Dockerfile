FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Blog.Service/Blog.Service.csproj", "Blog.Service/"]
COPY ["ApiDocument/ApiDocument.csproj", "ApiDocument/"]
COPY ["DataTransfer/DataTransfer.csproj", "DataTransfer/"]
COPY ["Common/Common.csproj", "Common/"]
COPY ["Database/Database.csproj", "Database/"]
COPY ["DataManager/DataManager.csproj", "DataManager/"]
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
