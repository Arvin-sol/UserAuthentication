using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAthentication.Domain.Entities;

namespace UserAuthentication.Application.DTOs;
public record UserDTO
{
    public static explicit operator UserDTO(User model)
    {
        return new UserDTO
        { FirstName = model.FirstName, LastName = model.LastName, };
    }
    public Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public IFormFile Image { get; set; }
}

