@echo off

%~d0
cd "%~dp0"


set NET_HOME=C:\Windows\Microsoft.NET\Framework\v4.0.30319
set MSBUILD_HOME=%NET_HOME%

set PATH=%NET_HOME%;%MSBUILD_HOME%;%PATH%


set UNXUTILS_HOME=%CD%\..!Soft\UnxUtils

set PATH=%PATH%;%UNXUTILS_HOME%\usr\local\wbin


set SANDCASTLE_HOME=%CD%\..\!Soft\Sandcastle
set SANDCASTLE_HFB_HOME=%CD%\..\!Soft\Sandcastle Help File Builder

set DXROOT=%SANDCASTLE_HOME%
set SHFBROOT=%SANDCASTLE_HFB_HOME%
