using MiniCRM.Core.Repositoeies.Interfaces;

namespace MiniCRM.Core.Services;

public class AuthService(
    IAuthRepository _authRepository) : IAuthService
{
    public async Task<bool> AuthenticateAsync(string login, string password)
    {
        return await _authRepository.AuthenticateAsync(login, password);
    }
}

public interface IAuthService
{
    Task<bool> AuthenticateAsync(string login, string password);
}