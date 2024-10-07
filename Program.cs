using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StockMarketData.Data;
using StockMarketData.Services;

namespace StockMarketData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var app = serviceProvider.GetRequiredService<App>();
            app.Run();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
                
            // Add application services
            services.AddTransient<App>();
            services.AddSingleton<IStockService, StockService>();

            //Add Database
            services.AddDbContext<StockMarketContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
            );

            // Add logging
            services.AddLogging(configure =>
            {
                configure.AddConsole();
                configure.AddDebug();
                configure.SetMinimumLevel(LogLevel.Information);
            });
        }
    }

    public class App
    {
        private readonly IStockService stockService;
        private readonly ILogger<App> _logger;

        public App(IStockService stockService, ILogger<App> logger)
        {
            this.stockService = stockService;
            _logger = logger;
        }

        public void Run()
        {
            _logger.LogInformation("Application starting...");
            stockService.GetStocks();
        }
    }
}
