using FPA.Core.Services.Interfaces.Education;
using System;
using System.Collections.Generic;
using System.Text;

namespace FPA.Core.Services.Interfaces
{
    public interface IDataManagerEducation
    {
        IEducationProgramRepository EducationProgram { get; }
        IEducationFormRepository EducationForm { get; }
        ISubjectRepository Subjects { get; }
        IDepartmentRepository Department { get; }
        IAttestationRepository Attestations { get; }
    }
}
