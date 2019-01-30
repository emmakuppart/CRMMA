FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["CRMMA/CRMMA.csproj", "CRMMA/"]
RUN dotnet restore "CRMMA/CRMMA.csproj"
COPY . .
WORKDIR "/src/CRMMA"
RUN dotnet build "CRMMA.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CRMMA.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CRMMA.dll"]