FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/StudentsCrud.Web.Host/StudentsCrud.Web.Host.csproj", "src/StudentsCrud.Web.Host/"]
COPY ["src/StudentsCrud.Web.Core/StudentsCrud.Web.Core.csproj", "src/StudentsCrud.Web.Core/"]
COPY ["src/StudentsCrud.Application/StudentsCrud.Application.csproj", "src/StudentsCrud.Application/"]
COPY ["src/StudentsCrud.Core/StudentsCrud.Core.csproj", "src/StudentsCrud.Core/"]
COPY ["src/StudentsCrud.EntityFrameworkCore/StudentsCrud.EntityFrameworkCore.csproj", "src/StudentsCrud.EntityFrameworkCore/"]
WORKDIR "/src/src/StudentsCrud.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/StudentsCrud.Web.Host", "src/StudentsCrud.Web.Host"]
COPY ["src/StudentsCrud.Web.Core", "src/StudentsCrud.Web.Core"]
COPY ["src/StudentsCrud.Application", "src/StudentsCrud.Application"]
COPY ["src/StudentsCrud.Core", "src/StudentsCrud.Core"]
COPY ["src/StudentsCrud.EntityFrameworkCore", "src/StudentsCrud.EntityFrameworkCore"]
WORKDIR "/src/src/StudentsCrud.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "StudentsCrud.Web.Host.dll"]
