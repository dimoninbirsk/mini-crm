namespace MiniCRM.Domain.Models;

public record Discount : BaseEntity
{
    public string Tag { get; set; } = string.Empty;
    public decimal DiscountPercentage { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}