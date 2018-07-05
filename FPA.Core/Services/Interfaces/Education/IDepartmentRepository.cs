using FPA.Core.Domain.Models.EducationEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FPA.Core.Services.Interfaces.Education
{
    public interface IDepartmentRepository : IAddData<Department>, IGetData<Department>
    {
    }
}
