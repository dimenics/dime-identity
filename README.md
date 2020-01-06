# Dime.Security

[![Build Status](https://dev.azure.com/dimenicsbe/Utilities/_apis/build/status/Identity%20-%20MAIN%20-%20CI?branchName=master)](https://dev.azure.com/dimenicsbe/Utilities/_build/latest?definitionId=87&branchName=master)

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

Use the package manager NuGet to install Dime.Security:

- dotnet cli: `dotnet add package Dime.Security`
- Package manager: `Install-Package Dime.Security`

## Usage

``` csharp
using System.Security;

public string GetUserTimeZone(ClaimsIdentity currentUser)
{
    return currentUser.GetUserClaim<string>("TimeZoneClaim");
}
```

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.
Please make sure to update tests as appropriate.

## License

MIT