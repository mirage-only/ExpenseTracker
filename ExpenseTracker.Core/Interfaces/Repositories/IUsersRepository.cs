using ExpenseTracker.Core.Models;

namespace ExpenseTracker.Core.Interfaces.Repositories;

public interface IUsersRepository
{
    public Task<uint> AddUser(User user);
    
    public Task<User?> GetUserByEmail(string email);
    
    public Task<User?> GetUserByEmailAndPasswordHash(string email, string passwordHash); 
    
    public Task<User?> GetUserById(uint userId);
    
    public Task DeleteUser(uint userId); 
}