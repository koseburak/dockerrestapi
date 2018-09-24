
FROM microsoft/dotnet:latest

WORKDIR /app

COPY /out /app

EXPOSE 20100/tcp

ENV ASPNETCORE_URLS="http://*:20100"

ENTRYPOINT [ "dotnet", "DockerRestApi.dll" ]
