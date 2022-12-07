using Autofac;
using Autofac.Extensions.DependencyInjection;
using StockData.Worker;
using Serilog;
using Serilog.Events;
using Microsoft.EntityFrameworkCore;
using StockData.Infrastructure;
using StockData.Infrastructure.DbContexts;

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", false)
                .AddEnvironmentVariables()
                .Build();

var connectionString = configuration.GetConnectionString("DefaultConnection");

var migrationAssemblyName = typeof(Worker).Assembly.FullName;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
    .Enrich.FromLogContext()
    .ReadFrom.Configuration(configuration)
    .CreateLogger();

try
{
    Log.Information("Application Starting up");

    IHost host = Host.CreateDefaultBuilder(args)
        .UseWindowsService()
        .UseServiceProviderFactory(new AutofacServiceProviderFactory())
        .UseSerilog()
        .ConfigureContainer<ContainerBuilder>(builder =>
        {
            builder.RegisterModule(new WorkerModule());
            builder.RegisterModule(new InfrastructureModule(connectionString, migrationAssemblyName));

        })
        .ConfigureServices((hostContext, services) =>
        {
            services.AddDbContext<ApplicationDbContext>(option =>
                    option.UseSqlServer(connectionString,
                        b => b.MigrationsAssembly(migrationAssemblyName)));
           
            services.AddHostedService<Worker>();
        })
        .Build();

    await host.RunAsync();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application start-up failed");
}
finally
{
    Log.CloseAndFlush();
}
