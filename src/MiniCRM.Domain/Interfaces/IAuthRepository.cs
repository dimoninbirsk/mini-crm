namespace MiniCRM.Core.Repositoeies.Interfaces;

public interface IAuthRepository
{
    Task<bool> AuthenticateAsync(string login, string password);
}