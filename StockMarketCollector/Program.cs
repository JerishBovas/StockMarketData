﻿using FmpClient;
using FmpClient.IServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StockMarketCollector.Data;
using StockMarketCollector.Models;

namespace StockMarketCollector
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var app = serviceProvider.GetRequiredService<App>();
            await app.Run();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddUserSecrets<Program>()
                .Build();
            
            // Add FmpClient
            services.AddFmpClient(configuration.GetSection("FMP_key").Value!, configuration.GetSection("FMP_Url").Value!);
                
            // Add application services
            services.AddTransient<App>();

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

    public class App(IFmpClient client, ILogger<App> logger, StockMarketContext stockMarketContext)
    {
        public async Task Run()
        {
            logger.LogInformation("Application starting...");
            var stocks = await client.Stocks.GetStocks();
            logger.LogInformation("Reached here");
            
            var newStocks = new List<Stock>();
            
            foreach (var stock in stocks)
            {
                if (stock.Name is null)
                {
                    logger.LogInformation($"Name: {stock.Symbol}", stock);
                    continue;
                }
                newStocks.Add(new Stock()
                {
                    Symbol = stock.Symbol,
                    Name = stock.Name,
                    Price = stock.Price ?? 0,
                    StockExchange = new StockExchange()
                    {
                        Name = stock.Exchange ?? "",
                        ShortName = stock.ExchangeShortName ?? "",
                    }
                });
            }
            
            stockMarketContext.Stocks.AddRange(newStocks);
            await stockMarketContext.SaveChangesAsync();
            logger.LogInformation("Saved");
        }
    }
}
