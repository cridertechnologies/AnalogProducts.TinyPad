using System.Text.Json;

namespace TinyPad
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }

        static AppConfig? _appConfig;
        public static AppConfig GetAppConfig()
        {
            try
            {
                if (_appConfig is not null)
                {
                    return _appConfig;
                }

                // Load config from file
                var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var configFilePath = Path.Combine(appDataPath, "TinyPad", "appconfig.json");

                if (File.Exists(configFilePath))
                {
                    var json = File.ReadAllText(configFilePath);
                    _appConfig = JsonSerializer.Deserialize<AppConfig>(json);
                    if (_appConfig is not null)
                    {
                        return _appConfig;
                    }
                }


                // Create default config
                _appConfig = new AppConfig()
                {
                    FontSize = 12
                };

                // Ensure the directory exists
                Directory.CreateDirectory(Path.GetDirectoryName(configFilePath)!);

                // Serialize config to JSON and save to file
                File.WriteAllText(configFilePath, JsonSerializer.Serialize(_appConfig));

                return _appConfig;
            }
            catch
            {
                // Return default config in case of error
                return new AppConfig()
                {
                    FontSize = 12
                };
            }
        }

        public static void SaveAppConfig(AppConfig config)
        {
            try
            {
                var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var configFilePath = Path.Combine(appDataPath, "TinyPad", "appconfig.json");
                // Ensure the directory exists
                Directory.CreateDirectory(Path.GetDirectoryName(configFilePath)!);
                // Serialize config to JSON and save to file
                File.WriteAllText(configFilePath, JsonSerializer.Serialize(config));
                // Update the cached config
                _appConfig = config;
            }
            catch
            {
                // Handle errors silently for now
            }
        }
    }
}