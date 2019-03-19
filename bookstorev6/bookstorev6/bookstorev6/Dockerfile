FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["bookstorev6/bookstorev6.csproj", "bookstorev6/"]
RUN dotnet restore "bookstorev6/bookstorev6.csproj"
COPY . .
WORKDIR "/src/bookstorev6"
RUN dotnet build "bookstorev6.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "bookstorev6.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "bookstorev6.dll"]