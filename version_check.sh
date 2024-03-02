#!/bin/bash

# Directory to search
dir=$1

# Iterate over all files in the directory
for file in "$dir"/*/version.json; do
    # Check if the file exists
    if [ -f "$file" ]; then
        # Extract the version number using the 'jq' command-line JSON processor
        version=$(jq -r '*.version*' "$file")

        # Print the file path and version number
        echo "$file: $version"
    fi
done