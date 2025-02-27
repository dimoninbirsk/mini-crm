using MiniCRM.Core.Domain;
using MiniCRM.Core.Services;

namespace MiniCRM.Core.Repository;

public record SQLiteProvider : IRepository<User>
{
    public Task Add(User model)
    {
        return Task.CompletedTask;
    }

    public Task<IEnumerable<User>> Get(int id)
    {
        List<User> result = new() { new User { Id = id, Login = "LLL", Password = "PPP" } };
        return result;
    }

    public Task<IEnumerable<User>> Get()
    {
        List<User> result = new()
        {
            new User { Id = 1, Login = "LLL", Password = "PPP" } ,
            new User { Id = 2, Login = "LLL", Password = "PPP" }
        };
        return result;
    }
}