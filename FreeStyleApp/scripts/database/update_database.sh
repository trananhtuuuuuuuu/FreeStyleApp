#!/bin/bash

# Update database with latest migrations
echo "Updating database..."

# Get script directory and navigate to project root
SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
PROJECT_DIR="$SCRIPT_DIR/../.."
CSPROJ_FILE="$PROJECT_DIR/FreeStyleApp.csproj"

# Verify project file exists
if [ ! -f "$CSPROJ_FILE" ]; then
    echo "Error: Project file not found at $CSPROJ_FILE"
    exit 1
fi

dotnet ef database update --project "$CSPROJ_FILE"

if [ $? -eq 0 ]; then
    echo "Database updated successfully!"
else
    echo "Database update failed!"
    exit 1
fi