using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAthentication.Domain.Entities;
using UserAthentication.Domain.IRepositories;
using UserAuthentication.Application.DTOs;

namespace UserAuthentication.Application.Commands.Handlers;
public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, UserDTO>
{
    private readonly IUserRepository _userRepository;
    public LoginUserCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<UserDTO> Handle(LoginUserCommand request, CancellationToken cancellationToken)
    {
        var findUser =  await _userRepository.FindUser(request.FirstName, request.Password);
        return (UserDTO)findUser;

    }
}

