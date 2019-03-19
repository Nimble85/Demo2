FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["bookstorev3.csproj", "bookstorev3/"]
RUN dotnet restore "bookstorev3/bookstorev3.csproj"
COPY . .
WORKDIR "/src/bookstorev3"
RUN dotnet build "bookstorev3.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "bookstorev3.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "bookstorev3.dll"]