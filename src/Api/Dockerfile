FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Whodo.Authentication.Api/Whodo.Autentication.Api.csproj", "Whodo.Autentication.Api/"]
RUN dotnet restore "Whodo.Authentication.Api/Whodo.Autentication.Api.csproj"
COPY . .
WORKDIR "/src/Whodo.Autentication.Api"
RUN dotnet build "Whodo.Autentication.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Whodo.Autentication.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Whodo.Autentication.Api.dll"]