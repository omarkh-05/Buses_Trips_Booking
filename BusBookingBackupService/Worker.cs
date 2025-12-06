
using Microsoft.Data.SqlClient;

namespace BusBookingBackupService
{
    public class DataBaseWorkerService : BackgroundService
    {
        private readonly ILogger<DataBaseWorkerService> _logger;
        private readonly IConfiguration _configuration;

        readonly string? _connectionString;
        readonly string? _backupPath;
        readonly string? _LogPath;

        public DataBaseWorkerService(ILogger<DataBaseWorkerService> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;

            _connectionString = _configuration.GetConnectionString("DefaultConnection");
            _backupPath = _configuration["Folders:Backup"];
            _LogPath = _configuration["Folders:Log"];

            if (!Directory.Exists(_backupPath))
            {
                Directory.CreateDirectory(_backupPath);
            }
            if (!Directory.Exists(_LogPath))
            {
                Directory.CreateDirectory(_LogPath);
            }
        }
        void Log(string message)
        {
            if (string.IsNullOrEmpty(_LogPath)) return;

            string filePath = Path.Combine(_LogPath, "BusesBookingWorkerService.txt");
            string msg = $"{message} [{DateTime.Now:yyyy-MM-dd HH:mm:ss}]\n";

            File.AppendAllText(filePath, msg);
        }

        void BackupDatabase()
        {
            try
            {
                if (_connectionString == null || _backupPath == null) return;
                string databaseName = "Buses_BookingSystem";
                string backupFileName = $"{databaseName}_Backup_{DateTime.Now:yyyyMMddHHmmss}.bak";
                string backupFilePath = Path.Combine(_backupPath, backupFileName);
                string backupQuery = $@"BACKUP DATABASE [{databaseName}]TO DISK = '{backupFilePath}' WITH INIT, FORMAT, STATS = 10;";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand(backupQuery, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                Log($"Database backup completed successfully. Backup file created at: {backupFilePath}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred during database backup.");
            }
        }


        public override Task StartAsync(CancellationToken cancellationToken)
        {
            try
            {
                Log("Worker started At :");
                return base.StartAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while starting the worker.");
                throw;
            }
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            try
            {

                Log("Worker Stopped At :");
                return base.StopAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while stopping the worker.");
                throw;
            }
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    BackupDatabase();

                    await Task.Delay(1000);
                }

            }
            catch (Exception ex)
            {
                Log(ex + " An error occurred during execution.");
                _logger.LogError(ex, "An error occurred during execution.");
            }
        }
    }
}
