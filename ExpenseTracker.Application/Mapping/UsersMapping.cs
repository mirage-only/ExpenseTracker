using ExpenseTracker.Application.DTOs;
using ExpenseTracker.Core.Models;

namespace ExpenseTracker.Application.Mapping;

public class UsersMapping
{
    public static User MapSignInDtoToUser(SignInDto signInDto)
    {
        return new User()
        {
            Username = signInDto.Username,

            Email = signInDto.Email,

            PasswordHash = signInDto.PasswordHash,

            RegistrationDate = signInDto.RegistrationDate,

            Role = signInDto.Role
        };
    }
}