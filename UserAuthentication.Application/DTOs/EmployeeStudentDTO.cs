using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAthentication.Domain.Enums;

namespace UserAuthentication.Application.DTOs;
public record EmployeeStudentDTO
{
    public StudyingOrGraduate? EducationStatus { get; set; }
    public ulong? StudentNo { get; set; }

    public OfficialOrContract? ContractType { get; set; }
    public ulong? PersonalNo { get; set; }
}

