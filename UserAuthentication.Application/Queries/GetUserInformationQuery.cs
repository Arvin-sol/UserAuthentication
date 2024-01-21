using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAuthentication.Application.DTOs;

namespace UserAuthentication.Application.Queries;
public class GetUserInformationQuery:IRequest<UserDTO>
{
    public Guid Id { get; set; }
}

