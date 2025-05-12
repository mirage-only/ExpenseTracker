using ExpenseTracker.Application.DTOs;
using ExpenseTracker.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.WebApi.Controllers;

[ApiController]
[Route("users")]
public class UsersController(IUsersService service) : ControllerBase
{
    [HttpPost("SignIn")]
    public async Task<IActionResult> SignIn([FromBody] SignInDto signInDto)
    {
        try
        {
            var userId = await service.SignIn(signInDto);

            return Ok(userId); //200
        }
        catch (NullReferenceException e)
        {
            return BadRequest(e.Message); //400
        }
        catch (InvalidCastException e)
        {
            return Conflict(e.Message); //409
        }
        catch (Exception e)
        {
            return Problem(e.Message); //500 - InternalServerError - общая по причине сервера
        }
    }

    [HttpGet("SignUp")]
    public async Task<IActionResult> SignUp([FromBody] SignUpDto signUpDto)
    {
        try
        {
            var userId = await service.SignUp(signUpDto);

            return Ok();
        }
        catch (ArgumentNullException e)
        {
            return BadRequest(e.Message); //400
        }
        catch (ArgumentException e)
        {
            return Unauthorized(e.Message); //401
        }
        catch (Exception e)
        {
            return Problem(e.Message); //500 - InternalServerError
        }
    }
}