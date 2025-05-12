using ExpenseTracker.Application.DTOs;
using ExpenseTracker.Application.Interfaces.Services;
using ExpenseTracker.Application.Mapping;
using ExpenseTracker.Core.Interfaces.Repositories;

namespace ExpenseTracker.Application.Services;

public class UsersService(IUsersRepository repository) : IUsersService
{
    public async Task<uint> SignIn(SignInDto signInDto)
    {
        var user = UsersMapping.MapSignInDtoToUser(signInDto);
        
        if(user == null) throw new NullReferenceException("User can't be null");
        
        if(await repository.GetUserByEmail(user.Email) != null) throw new InvalidOperationException("User with that email already exists");

        return await repository.AddUser(user);
    }

    public async Task<uint> SignUp(SignUpDto signUpDto)
    {
        if(signUpDto == null) throw new ArgumentNullException("SignUpDto can't be null");
        
        if(signUpDto.Email == null || signUpDto.PasswordHash == null) throw new ArgumentNullException("Email and Password can't be null");
        
        var user = await repository.GetUserByEmailAndPasswordHash(signUpDto.Email, signUpDto.PasswordHash);
        
        //InvalidCredentialsException
        if(user == null) throw new ArgumentException("Incorrect email or password");

        return user.Id;
    }
}