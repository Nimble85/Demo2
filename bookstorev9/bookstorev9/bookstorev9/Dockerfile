FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["bookstorev9/bookstorev9.csproj", "bookstorev9/"]
RUN dotnet restore "bookstorev9/bookstorev9.csproj"
COPY . .
WORKDIR "/src/bookstorev9"
RUN dotnet build "bookstorev9.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "bookstorev9.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "bookstorev9.dll"]