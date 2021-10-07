cd /d %~dp0
ECHO OFF
xcopy netcoreapp2.1\* "%ProgramFiles%\dotnet\sdk\NuGetFallbackFolder\microsoft.netcore.app\2.1.0\ref\netcoreapp2.1\" /e
pause