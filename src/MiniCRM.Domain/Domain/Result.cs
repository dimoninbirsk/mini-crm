namespace MiniCRM.Core.Domain;

public record Result<T>
{
    public required T Value { get; set; }
    public List<string> Error { get; set; } = [];
}