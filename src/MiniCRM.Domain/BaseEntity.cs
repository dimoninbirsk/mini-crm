namespace MiniCRM.Domain;

public abstract record BaseEntity
{
    public Ulid ULID { get; set; } = Ulid.NewUlid();
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}