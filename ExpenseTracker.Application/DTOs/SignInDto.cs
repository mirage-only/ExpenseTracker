using ExpenseTracker.Core.Enums;

namespace ExpenseTracker.Application.DTOs;

public class SignInDto
{
    public string Username { get; set; }
    
    public string Email { get; set; }
    
    public string PasswordHash { get; set; }

    public DateTime RegistrationDate { get; set; } = DateTime.Now;

    public RoleEnum Role { get; set; } = RoleEnum.User;
}