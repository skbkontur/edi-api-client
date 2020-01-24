@echo off

set SolutionName=EdiApi.Client

rem reset current directory to the location of this script
pushd "%~dp0"

if exist "./bin" (
    rd "./bin" /Q /S || exit /b 1
)


dotnet build --force --no-incremental --configuration Release "./%SolutionName%.sln" || exit /b 1

dotnet pack --no-build --configuration Release "./%SolutionName%.sln" || exit /b 1

pause