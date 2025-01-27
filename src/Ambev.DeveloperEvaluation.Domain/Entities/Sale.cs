namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Sale
{
    public int SaleId { get; set; }
    public string SaleNumber { get; set; }
    public DateTime SaleDate { get; set; }
    public int CustomerId { get; set; }
    public decimal TotalSaleAmount { get; set; }
    public string Branch { get; set; }
    public string Products { get; set; }
    public string Quantities { get; set; }
    public string UnitPrices { get; set; }
    public string Discounts { get; set; }
    public string TotalAmountForEachItem { get; set; }
    public bool IsCancelled { get; set; }

    public Customer Customer { get; set; }
}
