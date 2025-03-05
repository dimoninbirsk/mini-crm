namespace MiniCRM.Domain.Models;

public record Service : BaseEntity
{
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public bool IsActive { get; set; } = true;
    public string Tag { get; set; } = string.Empty;

    public ICollection<ServiceOrder> ServiceOrders { get; set; } = [];
}

public record ServiceOrder : BaseEntity
{
    public Ulid EmployeeId { get; set; }
    public User Employee { get; set; } = null!;

    public Ulid ServiceId { get; set; }
    public Service Service { get; set; } = null!;

    public ServiceOrderStatus Status { get; set; } = ServiceOrderStatus.Pending;
    public string CancellationReason { get; set; } = string.Empty; // Причина отмены, если услуга не выполнена
}

public enum ServiceOrderStatus
{
    Pending,
    InProgress,
    Completed,
    Cancelled
}