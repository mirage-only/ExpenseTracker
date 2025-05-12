using ExpenseTracker.Application.DTOs;
using ExpenseTracker.Core.Models;

namespace ExpenseTracker.Application.Interfaces.Services;

public interface IUsersService
{
    public Task<uint> SignIn(SignInDto signInDto);
    
    public Task<uint> SignUp(SignUpDto signUpDto);
}