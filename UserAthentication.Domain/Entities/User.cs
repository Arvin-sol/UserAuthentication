
using UserAthentication.Domain.Common;
using UserAthentication.Domain.Enums;

namespace UserAthentication.Domain.Entities;
public class User:BaseEntity
{
    public required string FirstName { get; set; }
    public string LastName { get; set; }
    public required string Password { get; set; }
    public StudentOrEmployee StudentOrEmployee { get; set; }
    public string? ImageSrc { get; set; }

    public ICollection<EmployeeStudent> employeeStudents { get; set; }

}

