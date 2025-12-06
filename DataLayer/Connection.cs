using Microsoft.Extensions.Configuration;

namespace DataLayer
{
    public class Connection
    {
        public static IConfiguration Configuration { get; }

        static Connection()
        {
            var builder = new ConfigurationBuilder()
    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();
        }

        public static string ConnectionString => Configuration.GetConnectionString("Buses_BookingSystem");
    }
}
