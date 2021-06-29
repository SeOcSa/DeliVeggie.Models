#!/bin/bash
export PATH="$PATH:/root/.dotnet/tools"

echo aws codeartifact list-package-versions --package my-package-name --domain $DOMAIN --domain-owner 043519888587 --repository $REPO --format npm --output text --query 'versions[*].[version]'
versions="a"
echo $versions
echo ${versions[@]}

if [ "${versions[@]}" = "0" ]; then
  dotnet pack -o .
  dotnet nuget push *.nupkg -s codeartifact
else
  latest_version=versions[${versions[@]}]

  IFS='.' read -r -a versions_array <<< $latest_version

  minorVersion=versions_array[${versions_array[@]}]
  majorVersion=versions_array[${versions_array[0]}]
  midVersion=versions_array[${versions_array[1]}]

  version="${majorVersion}.${midVersion}.${minorVersion}"
  dotnet pack -o . -p:version
  dotnet nuget push *.nupkg -s codeartifact
fi
