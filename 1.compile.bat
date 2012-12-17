@echo off

call "%~dp0_props.bat"


msbuild BillingSystem.csproj
