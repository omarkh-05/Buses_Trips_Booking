using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminBusesBooking.Forms.Users
{
    public static class LoggerConfig
    {
        public static IConfiguration Configuration { get; }

        static LoggerConfig()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();
        }

        public static string LogPath
        {
            get
            {
                string? path = Configuration["LogPath:Path"];

                if (string.IsNullOrWhiteSpace(path))
                    path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                return path;
            }
        }
    }

    public static class FileLogger
    {
        private static readonly object _lockObj = new object();

        public static void Log(string message)
        {
            try
            {
                string logDirectory = LoggerConfig.LogPath;

                // اذا بديش كل يوم جديد ينعمل ملف ينعمل 
                // string fileName = $"Log.txt";

                // اسم ملف اليوم
                string fileName = $"Log_{DateTime.Now:yyyy-MM-dd}.txt";

                string fullPath = Path.Combine(logDirectory, fileName);

                string logEntry =
                    $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}{Environment.NewLine}";

                lock (_lockObj)
                {
                    File.AppendAllText(fullPath, logEntry);
                }
            }
            catch
            {
                // لا نرمي exception حتى ما يوقف البرنامج في حال مشكلة باللوجر
            }
        }

        public static void LogError(Exception ex)
        {
            Log($"ERROR: {ex.Message}\nSTACKTRACE: {ex.StackTrace}");
        }
    }   

}
