using ExpenseTracker.Core.Interfaces.Repositories;
using ExpenseTracker.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Persistence.Repositories;

public class UsersRepository(ApplicationDbContext dbContext) : IUsersRepository
{
    public async Task<uint> AddUser(User user)
    {
        try
        {
            var addedUser = await dbContext.Users
                .AddAsync(user);

            await dbContext.SaveChangesAsync();

            return addedUser.Entity.Id;
        }
        catch
        {
            throw new Exception("Failed to sign up");
        }
    }

    public async Task<User?> GetUserByEmail(string email) //to sign up to check of already exists user
    {
        var user = await dbContext.Users
            .AsNoTracking()
            .FirstOrDefaultAsync(user => user.Email == email);

        return user;
    }

    public async Task<User?> GetUserByEmailAndPasswordHash(string email, string passwordHash)
    {
        var user = await dbContext.Users
            .AsNoTracking()
            .FirstOrDefaultAsync(user => user.Email == email && user.PasswordHash == passwordHash);
        
        return user;
    }

    public async Task<User?> GetUserById(uint userId)
    {
        var user = await dbContext.Users
            .FindAsync(userId);

        return user;
    }

    public async Task DeleteUser(User userToDelete)
    {
        dbContext.Remove(userToDelete);
        
        await dbContext.SaveChangesAsync();
    }
}