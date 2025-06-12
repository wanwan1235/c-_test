# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Type
This is a .NET Framework 4.7.2 Console Application written in C#.

## Build Commands
```bash
# Build in Debug mode
msbuild ConsoleApp2.csproj /p:Configuration=Debug

# Build in Release mode
msbuild ConsoleApp2.csproj /p:Configuration=Release

# Clean build output
msbuild ConsoleApp2.csproj /t:Clean

# Rebuild (clean + build)
msbuild ConsoleApp2.csproj /t:Rebuild
```

## Run Commands
```bash
# Run Debug build
./bin/Debug/ConsoleApp2.exe

# Run Release build
./bin/Release/ConsoleApp2.exe
```

## Project Structure
- **ConsoleApp2.csproj**: MSBuild project file defining build configuration, references, and compilation settings
- **Program.cs**: Entry point containing the Main method
- **App.config**: Application configuration file specifying .NET Framework runtime version
- **Properties/AssemblyInfo.cs**: Assembly metadata and attributes