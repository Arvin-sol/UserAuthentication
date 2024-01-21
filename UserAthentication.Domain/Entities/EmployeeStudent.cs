
using UserAthentication.Domain.Common;

namespace UserAthentication.Domain.Entities;
public class EmployeeStudent:BaseEntity
{
    public Guid UserId { get; set; }
    public Guid? EmployeeId { get; set; }
    public Guid? StudentId { get; set; }

    //Relations
    public User users { get; set; }
    public Employee employees { get; set; }
    public Student students { get; set;}
}

