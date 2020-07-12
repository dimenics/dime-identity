# Dime.Security

![Build Status](https://dev.azure.com/dimenicsbe/Utilities/_apis/build/status/dimenics.identity?branchName=master) ![Code coverage](https://img.shields.io/azure-devops/coverage/dimenicsbe/Utilities/152/master)

## Introduction

Extensions to the System.Security namespace.

## Getting Started

- You must have Visual Studio 2019 Community or higher.
- The dotnet cli is also highly recommended.

## About this project

Extensions to the System.Security namespace:

- ClaimsIdentity: fluent `ClaimsIdentity` builder class.
- ClaimsIdentityExtensions: useful extensions to the `ClaimsIdentity` class

## Build and Test

- Run dotnet restore
- Run dotnet build
- Run dotnet test

## Installation

Use the package manager NuGet to install Dime.Identity:

- dotnet cli: `dotnet add package Dime.Identity`
- Package manager: `Install-Package Dime.Identity`

## Usage

``` csharp
using System.Security;

public string GetUserTimeZone(ClaimsIdentity currentUser)
{
    return currentUser.GetUserClaim<string>("TimeZoneClaim");
}
```

## Contributing

![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)

Pull requests are welcome. Please check out the contribution and code of conduct guidelines.

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)