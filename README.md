# DevOps.Build.AppVeyor.GetBuildRecord

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-build-appveyor-getbuildrecord.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/devops-build-appveyor-getbuildrecord)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Build.AppVeyor.GetBuildRecord.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.GetBuildRecord)

## Description

Function gets the given repository's build record from the Azure Storage Table AppVeyor build ledger

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.DevOps.Build.AppVeyor.GetAzureTable](https://github.com/CDorst/DevOps.Build.AppVeyor.GetAzureTable) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-build-appveyor-getazuretable.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-build-appveyor-getazuretable) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Build.AppVeyor.GetAzureTable.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.GetAzureTable)
[CDorst.DevOps.Build.AppVeyor.AzureStorageTableLedger](https://github.com/CDorst/DevOps.Build.AppVeyor.AzureStorageTableLedger) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-build-appveyor-azurestoragetableledger.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-build-appveyor-azurestoragetableledger) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Build.AppVeyor.AzureStorageTableLedger.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.AzureStorageTableLedger)

## NuGet

This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.GetBuildRecord](https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.GetBuildRecord)

## Version

1.0.10

## Metaproject

DevOps.Build.AppVeyor.GetBuildRecord is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

