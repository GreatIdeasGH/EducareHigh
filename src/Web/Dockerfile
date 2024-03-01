FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

ENV ASPNETCORE_URLS=http://+:8080

USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["src/Web/GreatIdeas.EducareHigh.Web.csproj", "src/Web/"]
RUN dotnet restore "src/Web/GreatIdeas.EducareHigh.Web.csproj"
COPY . .
WORKDIR "/src/src/Web"
RUN dotnet build "GreatIdeas.EducareHigh.Web.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "GreatIdeas.EducareHigh.Web.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GreatIdeas.EducareHigh.Web.dll"]
