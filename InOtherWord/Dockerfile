#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["InOtherWord/InOtherWord.csproj", "InOtherWord/"]
RUN dotnet restore "InOtherWord/InOtherWord.csproj"
COPY . .
WORKDIR "/src/InOtherWord"
RUN dotnet build "InOtherWord.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "InOtherWord.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InOtherWord.dll"]