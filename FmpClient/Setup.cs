using FmpClient.IServices;
using FmpClient.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using RestSharp;

namespace FmpClient;

public static class Setup
{
    public static void AddFmpClient(this IServiceCollection services, string apiKey, string baseUrl)
    {
        services.AddLogging();

        services.AddSingleton<IRestClient>(_ =>
        {
            var options = new RestClientOptions(baseUrl);
            return new RestClient(options).AddDefaultParameter("apikey", apiKey);
        });

        services.TryAddTransient<IFmpClient, FmpClient>();
        services.TryAddTransient<IStockService, StockService>();
        // services.TryAddTransient<ICompanyValuationProvider, CompanyValuationProvider>();
        // services.TryAddTransient<IMarketIndexesProvider, MarketIndexesProvider>();
        // services.TryAddTransient<IAdvancedDataProvider, AdvancedDataProvider>();
        // services.TryAddTransient<ICalendarsProvider, CalendarsProvider>();
        // services.TryAddTransient<IInstitutionalFundProvider, InstitutionalFundProvider>();
        // services.TryAddTransient<IStockTimeSeriesProvider, StockTimeSeriesProvider>();
        // services.TryAddTransient<IStockMarketProvider, StockMarketProvider>();
        // services.TryAddTransient<ICryptoMarketProvider, CryptoMarketProvider>();
        // services.TryAddTransient<IStockStatisticsProvider, StockStatisticsProvider>();
        // services.TryAddTransient<IFundProvider, FundProvider>();
        // services.TryAddTransient<IEconomicsProvider, EconomicsProvider>();
    }
}