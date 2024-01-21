using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAthentication.Domain.Entities;

namespace UserAthentication.Domain.IRepositories;
public interface IEmployeeStudentRepository
{
    Task Create(EmployeeStudent model);
}

