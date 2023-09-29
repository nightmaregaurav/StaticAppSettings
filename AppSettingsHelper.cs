using Microsoft.Extensions.Configuration;

namespace StaticAppSettings
{
    public static class AppSettingsHelper
    {
        private static ConfigurationManager? _configuration;

        public static ConfigurationManager Configuration
        {
            get
            {
                if (_configuration != null) return _configuration;
                throw new Exception("Configuration Manager source not configured!");
            }
        }

        public static void Configure(ConfigurationManager configurationManager) => _configuration = configurationManager;
    }
}
