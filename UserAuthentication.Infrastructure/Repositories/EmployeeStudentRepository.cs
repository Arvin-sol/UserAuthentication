using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAthentication.Domain.Entities;
using UserAthentication.Domain.IRepositories;
using UserAuthentication.Infrastructure.Common;

namespace UserAuthentication.Infrastructure.Repositories;
public class EmployeeStudentRepository : IEmployeeStudentRepository
{
    private readonly ApplicationDbContext _context;
    public EmployeeStudentRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task Create(EmployeeStudent model)
    {
        await _context.Set<EmployeeStudent>().AddAsync(model);
    }
}

