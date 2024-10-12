namespace FmpClient.IServices;

public interface IFmpClient
{
    public IStockService Stocks { get; }
}