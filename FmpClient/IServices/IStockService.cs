using FmpClient.Models;

namespace FmpClient.IServices;

public interface IStockService
{
    public Task<List<StockDto>> GetStocks();

    public Task<List<StockDto>> GetEtfs();

    public Task<List<string>> GetStatementSymbols();

    public Task<List<StockDto>> GetActivelyTradedStocks();

    public Task GetCommitmentOfTradersReports();

    public Task GetCikList();

    public Task GetEuronetSymbols();

    public Task GetSymbolChanges();

    public Task GetExchangeSymbols(string symbol);

    public Task GetAvailableIndexes();
}