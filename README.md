# StaticAppSettings

StaticAppSettings is a C# library that provides a convenient way to manage and access configuration settings in your ASP.NET Core application. This library is built on top of `Microsoft.Extensions.Configuration` and offers static APIs to get configuration settings from `builder.Configuration`.

## Features

- Centralized configuration management.
- Thread-safe initialization and access to configuration settings.
- Supports loading settings from JSON files and environment variables.

## Usage

Here's how you can use StaticAppSettings to access your configuration settings:
Install the package from [NuGet](https://www.nuget.org/packages/nightmaregaurav.staticappsettings/).

```csharp
using StaticAppSettings;

// ...

var connectionString = AppSettingsHelper.GetSection("ConnectionStrings:DefaultConnection").Value;
```

## Configuration Sources

StaticAppSettings need to be configured in program.cs first:

```csharp
using StaticAppSettings;

// ...

AppSettingsHelper.Configure(builder.Configuration);
```

## License

StaticAppSettings is released under the MIT License. You can find the full license details in the [LICENSE](LICENSE) file.

Made with ❤️ by [NightmareGaurav](https://github.com/nightmaregaurav).

---
Open For Contribution
---

We welcome contributions to the StaticAppSettings project! If you have suggestions, bug reports, or feature requests, please open an issue or submit a pull request on our [GitHub repository](https://github.com/nightmaregaurav/StaticAppSettings). Let's make this project even better together!
