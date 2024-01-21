
using UserAthentication.Domain.Common;
using UserAthentication.Domain.Enums;

namespace UserAthentication.Domain.Entities;
public class Employee : BaseEntity
{
    public OfficialOrContract? ContractType { get; set; }
    public ulong? PersonalNo { get; set; }
}

