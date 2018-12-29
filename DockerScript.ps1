dotnet clean

Remove-Item -Recurse -Force ./out

dotnet build --configuration Release

dotnet publish DockerRestApi.csproj -c Release -o ./out


### begin docker image

docker build -t dockerrestapi .

#docker run -d -p 20100:20100 dockerrestapi -rm -it



### begin repository image registry

docker tag dockerrestapi funf/funfrepo:latest

docker push funf/funfrepo:latest
