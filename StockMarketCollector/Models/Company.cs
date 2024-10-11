using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMarketCollector.Models;

[Table("Companies")]
public class Company
{
    [Required, Key]
    public int Id { get; set; }

    [Required]
    public required string Name { get; set; }

    public int StockId { get; set; }

    public Stock Stock { get; set; } = null!;
    public double MarketCap { get; set; }
    public double LastDiv { get; set; }
    public string Range { get; set; } = "";
    public string Currency { get; set; } = "";
    public string? Cik { get; set; }
    public string? Isin { get; set; }
    public string? Cusip { get; set; }
    public string? Industry { get; set; }
    public string? Website { get; set; }
    public string? Description { get; set; }
    public string? CEO { get; set; }
    public string? Sector { get; set; }
    public string? Country { get; set; }
    public int FullTimeEmployees { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Zip { get; set; }
    public double DcfDiff { get; set; }
    public double Dcf { get; set; }
    public string? Image { get; set; }
    public DateTime IpoDate { get; set; }
    public bool DefaultImage { get; set; }
}