
using UserAthentication.Domain.Entities;

namespace UserAthentication.Domain.IRepositories;
public interface IUserRepository
{
    Task CreateUser(User model);
    Task<User> GetUserById(Guid id);
    Task<User> FindUser(string FirstName , string Password);
}

