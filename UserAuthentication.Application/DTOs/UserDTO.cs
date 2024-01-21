using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAthentication.Domain.Entities;
using UserAthentication.Domain.Enums;

namespace UserAuthentication.Application.DTOs;
public record UserDTO
{
    public static explicit operator UserDTO(User model)
    {
        return new UserDTO
        { 
            FirstName = model.FirstName,
            LastName = model.LastName,
            Password = model.Password,
            StudentOrEmployee = model.StudentOrEmployee
        };
    }
    public Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string Password { get; set; }
    public StudentOrEmployee StudentOrEmployee { get; set; }
    public IFormFile? Image { get; set; }
}

