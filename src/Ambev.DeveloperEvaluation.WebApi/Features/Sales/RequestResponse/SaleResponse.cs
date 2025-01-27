namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.RequestResponse;



public class CreateSaleResponse
{
    public int SaleId { get; set; }
    public string SaleNumber { get; set; }
    public DateTime SaleDate { get; set; }
    public int CustomerId { get; set; }
    public decimal TotalSaleAmount { get; set; }
    public string Branch { get; set; }
    public List<int> ProductIds { get; set; }
    public List<int> Quantities { get; set; }
    public List<decimal> UnitPrices { get; set; }
    public List<decimal> Discounts { get; set; }
    public List<decimal> TotalAmountForEachItem { get; set; }
    public bool IsCancelled { get; set; }
}
public class GetSaleResponse
{
    public int SaleId { get; set; }
    public string SaleNumber { get; set; }
    public DateTime SaleDate { get; set; }
    public int CustomerId { get; set; }
    public decimal TotalSaleAmount { get; set; }
    public string Branch { get; set; }
    public List<int> ProductIds { get; set; }
    public List<int> Quantities { get; set; }
    public List<decimal> UnitPrices { get; set; }
    public List<decimal> Discounts { get; set; }
    public List<decimal> TotalAmountForEachItem { get; set; }
    public bool IsCancelled { get; set; }
}