namespace MiniCRM.Domain.Models;

public record User
{
    public int Id { get; set; }
    public string Login { get; set; } = null!;
    public string Password { get; set; } = null!;
}

public record Product
{
    public int Id { get; set; }
    public string ProductName { get; set; } = null!;
    public string ProductDescription { get; set; } = null!;
    public Category ProductCategory { get; set; } = null!;
    public bool OnSale { get; set; }
}

public record Category
{
    public CategoryType Type { get; set; }
    public string CategoryName { get; set; } = null!;
}

public enum CategoryType
{
    Product,
    Service,
}