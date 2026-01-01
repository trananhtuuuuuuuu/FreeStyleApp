#!/bin/bash

# Remove the last migration
echo "WARNING: This will remove the last migration!"
read -p "Are you sure you want to continue? (y/n): " -n 1 -r
echo

if [[ $REPLY =~ ^[Yy]$ ]]; then
    echo "Removing ..."
    dotnet ef migrations remove
    
    if [ $? -eq 0 ]; then
        echo "Migration removed successfully!"
    else
        echo "Failed to remove migration!"
        exit 1
    fi
else
    echo "Operation cancelled."
    exit 0
fi