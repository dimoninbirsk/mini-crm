namespace MiniCRM.Core.Domain;

public interface IRepository<T>
{
    public Task<IEnumerable<T>> Get(int id);

    public Task<IEnumerable<T>> Get();

    public Task Add(T model);
}