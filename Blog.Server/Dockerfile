FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Blog.Server/Blog.Server.csproj", "Blog.Server/"]
COPY ["DataTransfer/DataTransfer.csproj", "DataTransfer/"]
COPY ["Common/Common.csproj", "Common/"]
COPY ["Database/Database.csproj", "Database/"]
RUN dotnet restore "Blog.Server/Blog.Server.csproj"
COPY . .
WORKDIR "/src/Blog.Server"
RUN dotnet build "Blog.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Blog.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Blog.Server.dll"]