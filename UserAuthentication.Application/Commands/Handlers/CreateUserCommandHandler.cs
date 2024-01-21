
using MediatR;
using UserAthentication.Domain.Entities;
using UserAthentication.Domain.IRepositories;
using UserAuthentication.Application.Common;

namespace UserAuthentication.Application.Commands.Handlers;
public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _uow;
    public CreateUserCommandHandler(IUserRepository userRepository, IUnitOfWork uow)
    {
        _userRepository = userRepository;
        _uow = uow;
    }
    public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var imageName = CodeGenerator.GenerateUniqCode() + Path.GetExtension("/Images");
        request.Image.AddImageToServer(imageName , request.Image.FileName);
        User newUser = new()
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            ImageSrc = imageName,
            Password = request.Password,
            StudentOrEmployee = request.StudentOrEmployee
        };
        await _userRepository.CreateUser(newUser);

        return await _uow.SaveChangesAsync();


    }
}

