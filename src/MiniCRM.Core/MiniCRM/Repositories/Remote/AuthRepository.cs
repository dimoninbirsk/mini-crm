using MiniCRM.Core.Repositoeies.Interfaces;

namespace MiniCRM.Core.Repositoeies.Remote;

public class AuthRepository : IAuthRepository
{
    public async Task<bool> AuthenticateAsync(string login, string password)
    {
        return (login, password)
            switch
        {
            ("admin", "admin") => true,
            ("user", "user") => true,
            _ => false,
        };
    }
}