using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAuthentication.Application.DTOs;

namespace UserAuthentication.Application.Commands;
public class LoginUserCommand:IRequest<UserDTO>
{
    public string FirstName { get; set; }
    public string Password { get; set; }
}

