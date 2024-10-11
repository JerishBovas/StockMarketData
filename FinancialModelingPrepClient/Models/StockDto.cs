using System.Text.Json.Serialization;

namespace FinancialModelingPrepClient.Models;

public class StockDto
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }
    
    [JsonPropertyName("name")]
    public string? Name { get; init; }
    
    [JsonPropertyName("price")]
    public double? Price { get; init; }
    
    [JsonPropertyName("exchange")]
    public string? Exchange { get; init; }
    
    [JsonPropertyName("exchangeShortName")]
    public string? ExchangeShortName { get; init; }
    
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}