FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["bookstorev5/bookstorev5.csproj", "bookstorev5/"]
RUN dotnet restore "bookstorev5/bookstorev5.csproj"
COPY . .
WORKDIR "/src/bookstorev5"
RUN dotnet build "bookstorev5.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "bookstorev5.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "bookstorev5.dll"]