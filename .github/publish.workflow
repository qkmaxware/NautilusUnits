jobs:
  publish:
    name: "Pack & Publish"
    runs-on: ubuntu-latest
    steps: 
    - name: "Pack"
      uses: mcr.microsoft.com/dotnet/core/sdk:3.0
      run: "dotnet pack Units"
    - name: "Publish"
      uses: mcr.microsoft.com/dotnet/core/sdk:3.0
      env:
        GITHUB_TOKEN: ${{ secrets.GITHUB_TOKEN }}
        GITHUB_SOURCE: https://nuget.pkg.github.com/qkmaxware/index.json
      run: "dotnet nuget push Units --api-key ${GITHUB_TOKEN} --source ${GITHUB_SOURCE}" 