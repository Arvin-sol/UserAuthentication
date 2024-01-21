
namespace UserAthentication.Domain.Common;

public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime CreateDate { get; set; } = DateTime.Now;
}

