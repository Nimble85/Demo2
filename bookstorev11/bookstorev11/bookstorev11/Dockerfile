FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY ["bookstorev11/bookstorev11.csproj", "bookstorev11/"]
RUN dotnet restore "bookstorev11/bookstorev11.csproj"
COPY . .
WORKDIR "/src/bookstorev11"
RUN dotnet build "bookstorev11.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "bookstorev11.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "bookstorev11.dll"]