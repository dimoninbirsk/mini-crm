using MiniCRM.Core.Domain;

namespace MiniCRM.Core.Services;

internal class AuthService(
    IRepository<User> _dbContext
    )
{
    public async Task<Result<bool>> Register(AuthVM model)
    {
        if (string.IsNullOrEmpty(model.Login) || string.IsNullOrEmpty(model.Password))
        {
            return new Result<bool>()
            {
                Value = false,
                Error = ["Пустой логин или пароль"],
            };
        }

        await _dbContext.Add(new User()
        {
            Login = model.Login,
            Password = model.Password
        });

        return new Result<bool>() { Value = true };
    }

    public async Task Login(AuthVM model)
    {
        // Validate
        var accounts = await _dbContext.Get(1);
        foreach (var item in accounts)
        {
            Console.WriteLine(item);
        }
        // Access DB

        //Grant Access
    }
}

public record AuthVM
{
    public string Login { get; set; } = null!;
    public string Password { get; set; } = null!;
}