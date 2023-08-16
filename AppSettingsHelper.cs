using Microsoft.Extensions.Configuration;

namespace StaticAppSettings
{
    public static class AppSettingsHelper
    {
        private static readonly object LockObject = new();
        private static IConfigurationRoot? _configuration;

        private static IConfigurationRoot AllConfigurations
        {
            get
            {
                if (_configuration != null) return _configuration;

                lock (LockObject)
                {
                    var currentExecutionDirectory = Directory.GetCurrentDirectory();
                    var mode = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Development";

                    var configuration = new ConfigurationBuilder()
                        .SetBasePath(currentExecutionDirectory)
                        .AddJsonFile("appsettings.json", false, true)
                        .AddJsonFile($"appsettings.{mode}.json", true, true)
                        .AddEnvironmentVariables()
                        .Build();

                    _configuration = configuration;
                    return configuration;
                }
            }
        }

        public static IConfigurationSection GetSection(string key) => AllConfigurations.GetSection(key);
        public static IConfigurationRoot GetAllConfigurations() => AllConfigurations;
    }
}
