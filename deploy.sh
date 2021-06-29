#!/bin/bash
export PATH="$PATH:/root/.dotnet/tools"

versions=$(aws codeartifact list-package-versions --package deliveggie.models --domain $DOMAIN --domain-owner 043519888587 --repository $REPO --format nuget --output text --query 'versions[*].[version]')

if [ -z "$versions" ]; then
  dotnet pack -o .
  dotnet nuget push *.nupkg -s codeartifact
else
  latest_version=versions[${versions[@]}]

  IFS='.' read -r -a versions_array <<< $latest_version

  minorVersionValue=versions_array[2]
  ((minorVersionValue++))
  minorVersion=minorVersionValue
  majorVersion=versions_array[${versions_array[0]}]
  midVersion=versions_array[${versions_array[1]}]

  version="${majorVersion}.${midVersion}.${minorVersion}"
  echo $version
  dotnet pack -o . -p:$version
  dotnet nuget push *.nupkg -s codeartifact
fi
