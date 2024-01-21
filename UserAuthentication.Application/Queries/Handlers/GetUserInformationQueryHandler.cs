
using MediatR;
using UserAthentication.Domain.IRepositories;
using UserAuthentication.Application.DTOs;

namespace UserAuthentication.Application.Queries.Handlers;
public class GetUserInformationQueryHandler : IRequestHandler<GetUserInformationQuery, UserDTO>
{
    private readonly IUserRepository _userRepository;
    public GetUserInformationQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<UserDTO> Handle(GetUserInformationQuery request, CancellationToken cancellationToken)
    {
        var user =  await _userRepository.GetUserById(request.Id);
        return (UserDTO)user;
    }
}

