
using MediatR;
using UserAthentication.Domain.Entities;
using UserAthentication.Domain.IRepositories;
using UserAuthentication.Application.Common;

namespace UserAuthentication.Application.Commands.Handlers;
public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
{
    private readonly IUserRepository _userRepository;
    private readonly IEmployeeStudentRepository _employeeStudentRepository;
    private readonly IUnitOfWork _uow;
    public CreateUserCommandHandler(IUserRepository userRepository, IUnitOfWork uow, IEmployeeStudentRepository employeeStudentRepository)
    {
        _userRepository = userRepository;
        _uow = uow;
        _employeeStudentRepository = employeeStudentRepository;

    }
    public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var imageName = CodeGenerator.GenerateUniqCode() + Path.GetExtension("/Images");
        request.UserDTO.Image.AddImageToServer(imageName , request.UserDTO.Image.FileName);
        
        User newUser = new()
        {
            FirstName = request.UserDTO.FirstName,
            LastName = request.UserDTO.LastName,
            ImageSrc = imageName,
            Password = request.UserDTO.Password,
            StudentOrEmployee = request.UserDTO.StudentOrEmployee
        };
        await _userRepository.CreateUser(newUser);

        if (newUser.StudentOrEmployee == 0)
        {
            Student newstudent = new()
            {
                EducationStatus = request.EmployeeStudent.EducationStatus,
                StudentNo = request.EmployeeStudent.StudentNo
            };
            EmployeeStudent employeeStudent = new()
            {
                UserId = newUser.Id,
                StudentId = newstudent.Id,
            };
            await _employeeStudentRepository.Create(employeeStudent);
        }
        else
        {
            Employee newemployee = new()
            {
                ContractType = request.EmployeeStudent.ContractType,
                PersonalNo = request.EmployeeStudent.PersonalNo,
            };
            EmployeeStudent employeeStudent = new()
            {
                UserId = newUser.Id,
                EmployeeId = newemployee.Id
            };
            await _employeeStudentRepository.Create(employeeStudent);
        }
        return await _uow.SaveChangesAsync();
    }
}

