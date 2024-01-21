using MediatR;
using Microsoft.AspNetCore.Http;
using UserAthentication.Domain.Entities;
using UserAthentication.Domain.Enums;
using UserAuthentication.Application.DTOs;

namespace UserAuthentication.Application.Commands;
public class CreateUserCommand:IRequest<bool>
{
    public UserDTO UserDTO { get; set; }

    public EmployeeStudentDTO EmployeeStudent { get; set; } 


}

