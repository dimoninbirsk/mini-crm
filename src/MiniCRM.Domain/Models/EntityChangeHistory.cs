namespace MiniCRM.Domain.Models;

public record EntityChangeHistory : BaseEntity
{
    public Ulid EntityId { get; set; }
    public string EntityType { get; set; } = null!;
    public string ChangeDescription { get; set; } = string.Empty;
    public Ulid ChangedByUserId { get; set; }
    public User ChangedByUser { get; set; } = null!;
}