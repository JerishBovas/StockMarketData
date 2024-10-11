using FinancialModelingPrepClient.IServices;
using Microsoft.Extensions.Logging;
using RestSharp;
using FinancialModelingPrepClient.Models;

namespace FinancialModelingPrepClient.Services;

public class StockService(ILogger<StockService> logger, IRestClient restClient) : IStockService
{
    public Task<List<StockDto>> GetActivelyTradedStocks()
    {
        throw new NotImplementedException();
    }

    public Task GetAvailableIndexes()
    {
        throw new NotImplementedException();
    }

    public Task GetCikList()
    {
        throw new NotImplementedException();
    }

    public Task GetCommitmentOfTradersReports()
    {
        throw new NotImplementedException();
    }

    public Task<List<StockDto>> GetEtfs()
    {
        throw new NotImplementedException();
    }

    public Task GetEuronetSymbols()
    {
        throw new NotImplementedException();
    }

    public Task GetExchangeSymbols(string symbol)
    {
        throw new NotImplementedException();
    }

    public Task<List<string>> GetStatementSymbols()
    {
        throw new NotImplementedException();
    }

    public async Task<List<StockDto>> GetStocks()
    {
        logger.LogInformation("Fetching Stocks...");
        
        try
        {
            var request = new RestRequest("v3/stock/list");
            var response = await restClient.GetAsync<List<StockDto>>(request);

            return response ?? [];
        }catch(Exception e)
        {
            logger.LogError(e.Message);
        }
        return new List<StockDto>();
    }

    public Task GetSymbolChanges()
    {
        throw new NotImplementedException();
    }
}