
using UserAthentication.Domain.Entities;
using UserAthentication.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;
using UserAuthentication.Infrastructure.Common;
using Microsoft.IdentityModel.Tokens;

namespace UserAuthentication.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;
    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task CreateUser(User model)
    => await _context.Set<User>().AddAsync(model);

    public async Task<User> FindUser(string FirstName, string Password)
    =>
       await _context.Users.FirstOrDefaultAsync(x => x.FirstName == FirstName && x.Password == Password); 
    

    public async Task<User> GetUserById(Guid id)
        => await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

}
