namespace MiniCRM.Domain.Models;

public record Expenses : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = string.Empty;
    public decimal Cost { get; set; }
    public int Count { get; set; } = 1;
    public decimal TotalCost => Cost * Count;
}