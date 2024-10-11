using FinancialModelingPrepClient.IServices;

namespace FinancialModelingPrepClient;

public class FmpClient(IStockService stocks) : IFmpClient
{
    
    public IStockService Stocks { get; } = stocks;

    // public ICompanyValuationProvider CompanyValuation { get; }
    //
    // public IMarketIndexesProvider MarketIndexes { get; }
    //
    // public IAdvancedDataProvider AdvancedData { get; }
    //
    // public ICalendarsProvider Calendars { get; }
    //
    // public IInstitutionalFundProvider InstitutionalFund { get; }
    //
    // public IStockTimeSeriesProvider StockTimeSeries { get; }
    //
    // public IStockMarketProvider StockMarket { get; }
    //
    // public IStockStatisticsProvider StockStatistics { get; }
    //
    // public ICryptoMarketProvider Crypto { get; }
    //
    // public IFundProvider Fund { get; }
    //
    // public IEconomicsProvider Economics { get; }

    // public FinancialModelingPrepApiClient(ICompanyValuationProvider companyValuation,
    //     IMarketIndexesProvider marketIndexes,
    //     IAdvancedDataProvider advancedData,
    //     ICalendarsProvider calendars,
    //     IInstitutionalFundProvider institutionalFund,
    //     IStockTimeSeriesProvider stockTimeSeries,
    //     IStockMarketProvider stockMarket,
    //     IStockStatisticsProvider stockStatistics,
    //     ICryptoMarketProvider cryptoMarket,
    //     IFundProvider fund,
    //     IEconomicsProvider economics)
    // {
    //     CompanyValuation = companyValuation;
    //     MarketIndexes = marketIndexes;
    //     AdvancedData = advancedData;
    //     Calendars = calendars;
    //     InstitutionalFund = institutionalFund;
    //     StockTimeSeries = stockTimeSeries;
    //     StockMarket = stockMarket;
    //     StockStatistics = stockStatistics;
    //     Crypto = cryptoMarket;
    //     Fund = fund;
    //     Economics = economics;
    // }
}