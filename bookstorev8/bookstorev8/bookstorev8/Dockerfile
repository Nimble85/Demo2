FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["bookstorev8/bookstorev8.csproj", "bookstorev8/"]
RUN dotnet restore "bookstorev8/bookstorev8.csproj"
COPY . .
WORKDIR "/src/bookstorev8"
RUN dotnet build "bookstorev8.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "bookstorev8.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "bookstorev8.dll"]