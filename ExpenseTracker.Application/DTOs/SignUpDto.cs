namespace ExpenseTracker.Application.DTOs;

public class SignUpDto
{
    public string Email { get; set; }
    
    public string PasswordHash { get; set; }
}