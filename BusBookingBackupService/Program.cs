using BusBookingBackupService;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<DataBaseWorkerService>();
    })
    // Configure as a Windows Service
    .UseWindowsService(options =>
    {
        options.ServiceName = "DataBase Backup Worker Service";
    })
    .Build();

host.Run();