using ExpenseTracker.Core.Enums;

namespace ExpenseTracker.Core.Models;

public class User
{
    public uint Id { get; set; }
    
    public string Username { get; set; }
    
    public string Email { get; set; }
    
    public string PasswordHash { get; set; }
    
    public DateTime RegistrationDate { get; set; }
    
    public List<Transaction> Transactions { get; set; }
    
    public RoleEnum Role { get; set; } = RoleEnum.User;
}