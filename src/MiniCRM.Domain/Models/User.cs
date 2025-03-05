namespace MiniCRM.Domain.Models;

public record User : BaseEntity
{
    public string Username { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public UserRole Role { get; set; } = UserRole.Employee;

    //public ICollection<ProductOrder> ProductOrders { get; set; } = [];
    //public ICollection<ServiceOrder> ServiceOrders { get; set; } = [];
    public ICollection<EntityChangeHistory> Changes { get; set; } = [];
}

public enum UserRole
{
    Employee,
    Admin,
}