namespace MiniCRM.Domain.Models;

public record Product : BaseEntity
{
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public int Quantity { get; set; } = 1;
    public bool IsActive { get; set; } = true;
    public string Tag { get; set; } = string.Empty;

    public ICollection<ProductOrderItem> OrderItems { get; set; } = [];
}

public record ProductOrder : BaseEntity
{
    public Ulid EmployeeId { get; set; }
    public User Employee { get; set; } = null!;

    public ICollection<ProductOrderItem> Items { get; set; } = [];
    public decimal TotalPrice => Items.Sum(item => item.Price * item.Quantity);
}

public record ProductOrderItem : BaseEntity
{
    public Ulid ProductOrderId { get; set; }
    public ProductOrder ProductOrder { get; set; } = null!;

    public Ulid ProductId { get; set; }
    public Product Product { get; set; } = null!;

    public int Quantity { get; set; }
    public decimal Price { get; set; }
}