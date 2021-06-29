#!/bin/bash

for ((/f %i in (aws codeartifact list-package-versions --package my-package-name --domain $DOMAIN --domain-owner 043519888587 --repository $REPO --format npm --output text --query 'versions[*].[version]')); do
  set CODEARTIFACT_VERSION = %i
done

IFS='.' read -r -a versions_array <<< CODEARTIFACT_VERSION

minorVersion =  versions_array[${versions_array[@]}]
majorVersion =  versions_array[${versions_array[0]}]
midVersion =  versions_array[${versions_array[1]}]

version = "${majorVersion}.${midVersion}.${minorVersion}"
dotnet pack -o . -p:version
dotnet nuget push *.nupkg -s codeartifact
