#!/bin/bash

# Add new migration to Infrastructure/Data/Migration folder
if [ -z "$1" ]; then
    echo "Error: Migration name is required!"
    exit 1
fi

MIGRATION_NAME=$1

# Get the directory where the script is located
SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
PROJECT_DIR="$SCRIPT_DIR/../.."
CSPROJ_FILE="$PROJECT_DIR/FreeStyleApp.csproj"

# Verify project file exists



if [ ! -f "$CSPROJ_FILE" ]; then
    echo "Error: Project file not found at $CSPROJ_FILE"
    exit 1
fi

echo "Creating migration: $MIGRATION_NAME"

# dotnet ef migrations add "Your_migration_name" --output-dir Infrastructure/Migrations
dotnet ef migrations add "$MIGRATION_NAME" \
    --project "$CSPROJ_FILE/FreeStyleApp.csproj" \
    --output-dir Infrastructure/Migrations

if [ $? -eq 0 ]; then
    echo "Migration '$MIGRATION_NAME' created successfully!"
    echo "Location: Infrastructure/Migrations/"
else
    echo "Failed!"
    exit 1
fi