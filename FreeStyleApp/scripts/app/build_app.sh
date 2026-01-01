#!/bin/bash

# Build the ASP.NET application
echo "Building ..."
dotnet build

if [ $? -eq 0 ]; then
    echo "Succeeded!"
else
    echo "Failed!"
    exit 1
fi