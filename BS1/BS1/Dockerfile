FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY ["BS1/BS1.csproj", "BS1/"]
RUN dotnet restore "BS1/BS1.csproj"
COPY . .
WORKDIR "/src/BS1"
RUN dotnet build "BS1.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "BS1.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BS1.dll"]