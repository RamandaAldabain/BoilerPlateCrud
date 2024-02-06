FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/StudentsCrud.Web.Mvc/StudentsCrud.Web.Mvc.csproj", "src/StudentsCrud.Web.Mvc/"]
COPY ["src/StudentsCrud.Web.Core/StudentsCrud.Web.Core.csproj", "src/StudentsCrud.Web.Core/"]
COPY ["src/StudentsCrud.Application/StudentsCrud.Application.csproj", "src/StudentsCrud.Application/"]
COPY ["src/StudentsCrud.Core/StudentsCrud.Core.csproj", "src/StudentsCrud.Core/"]
COPY ["src/StudentsCrud.EntityFrameworkCore/StudentsCrud.EntityFrameworkCore.csproj", "src/StudentsCrud.EntityFrameworkCore/"]
WORKDIR "/src/src/StudentsCrud.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/StudentsCrud.Web.Mvc", "src/StudentsCrud.Web.Mvc"]
COPY ["src/StudentsCrud.Web.Core", "src/StudentsCrud.Web.Core"]
COPY ["src/StudentsCrud.Application", "src/StudentsCrud.Application"]
COPY ["src/StudentsCrud.Core", "src/StudentsCrud.Core"]
COPY ["src/StudentsCrud.EntityFrameworkCore", "src/StudentsCrud.EntityFrameworkCore"]
WORKDIR "/src/src/StudentsCrud.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "StudentsCrud.Web.Mvc.dll"]
