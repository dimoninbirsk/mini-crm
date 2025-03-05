using Microsoft.EntityFrameworkCore;
using MiniCRM.Core.Repositoeies.Interfaces;
using MiniCRM.Data;

namespace MiniCRM.Core.Repositoeies.Local;

public class AuthRepository(
    AppDbContext _dbContext) : IAuthRepository
{
    public async Task<bool> AuthenticateAsync(string login, string password)
    {
        return await _dbContext.Users
            .FirstOrDefaultAsync(u => u.Login == login && u.Password == password) == null;
    }
}