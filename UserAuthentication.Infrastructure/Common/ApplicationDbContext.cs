
using Microsoft.EntityFrameworkCore;
using UserAthentication.Domain.Entities;

namespace UserAuthentication.Infrastructure.Common;
public sealed class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){}

    public DbSet<User> Users { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<EmployeeStudent> EmployeeStudents { get; set; }
}

