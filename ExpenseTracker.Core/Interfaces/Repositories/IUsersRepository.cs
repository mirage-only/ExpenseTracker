using ExpenseTracker.Core.Models;

namespace ExpenseTracker.Core.Interfaces.Repositories;

public interface IUsersRepository
{
    public Task<uint> SignUp(User user);
    
    public Task<User> GetUserByEmail(string email);
    
    public Task<uint> SignIn(string email, string passwordHash); 
    
    public Task<uint> GetUserById(uint userId);
    
    public Task DeleteUser(uint userId); 
}