dotnet clean

Remove-Item -Recurse -Force ./out

dotnet build --configuration Release

dotnet publish DockerRestApi.csproj -c Release -o ./out


### begin docker image

docker build -t dockerrestapi .

#docker run -d -p 20100:20100 dockerrestapi -rm -it



### begin repository image registry

docker tag dockerrestapi registry.cna.turkcell.tgc/library/funf/dockerrestapi:latest

docker push registry.cna.turkcell.tgc/library/funf/dockerrestapi:latest


### openshift cli
#oc login https://ocp-master.ocp.turkcell.tgc

oc import-image dockerrestapi --from=registry.cna.turkcell.tgc/library/funf/dockerrestapi:latest --confirm
