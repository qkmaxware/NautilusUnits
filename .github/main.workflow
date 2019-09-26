on:
  push: 
    branches: 
    - "master"
jobs:
  test:
    name: "Test"
    runs-on: ${{ matrix.os }}
    strategy:
      matrix:
        os: [ubuntu-latest, windows-latest, macos-latest]
    steps:
    - name: "Run Unit Tests"
      uses: mcr.microsoft.com/dotnet/core/sdk:3.0
      run: "dotnet test Units.Tests"
    - name: "Run Examples"
      uses: mcr.microsoft.com/dotnet/core/sdk:3.0
      run: "dotnet run Units.Examples"
  build:
    name: "Build & Pack"
    runs-on: ubuntu-latest
    needs: [ Test ]
    steps: 
    - name: "Build"
      uses: mcr.microsoft.com/dotnet/core/sdk:3.0
      run: "dotnet build Units"
    - name: "Pack"
      uses: mcr.microsoft.com/dotnet/core/sdk:3.0
      run: "dotnet pack Units"
