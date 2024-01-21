
using UserAthentication.Domain.Common;
using UserAthentication.Domain.Enums;

namespace UserAthentication.Domain.Entities;
public class Student:BaseEntity
{
    public StudyingOrGraduate? EducationStatus { get; set; }
    public ulong? StudentNo { get; set; }
}

