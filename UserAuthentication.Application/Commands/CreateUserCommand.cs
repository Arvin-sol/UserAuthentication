using MediatR;
using Microsoft.AspNetCore.Http;
using UserAthentication.Domain.Entities;
using UserAthentication.Domain.Enums;
using UserAuthentication.Application.DTOs;

namespace UserAuthentication.Application.Commands;
public class CreateUserCommand:IRequest<bool>
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string Password { get; set; }
    public StudentOrEmployee StudentOrEmployee { get; set; }
    public IFormFile? Image { get; set; }

}

